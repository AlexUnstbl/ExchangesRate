using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExchangesRate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Получить данные CBR
        private async Task<List<Currency>> GetCBRRate(DateTime date)
        {
            List<Currency> currencyList = new List<Currency>();

            XDocument xdoc = await GetCBRData(date);

            //Id валют в XML документе
            string usdID = "R01235";
            string eurID = "R01239";
            string cnyID = "R01375";
            string gbpID = "R01035";

            //Берём данные из XML документа
            var el = xdoc.Element("ValCurs").Elements("Valute");

            //Создаём экземпляр класса Валют для каждой из валют
            Currency usd = new Currency(el.Where(x => x.Attribute("ID").Value == usdID).Select(x => x.Element("Value").Value).FirstOrDefault(), 1);
            currencyList.Add(usd);
            Currency eur = new Currency(el.Where(x => x.Attribute("ID").Value == eurID).Select(x => x.Element("Value").Value).FirstOrDefault(), 2);
            currencyList.Add(eur);
            Currency cny = new Currency(el.Where(x => x.Attribute("ID").Value == cnyID).Select(x => x.Element("Value").Value).FirstOrDefault(), 3);
            currencyList.Add(cny);
            Currency gbp = new Currency(el.Where(x => x.Attribute("ID").Value == gbpID).Select(x => x.Element("Value").Value).FirstOrDefault(), 4);
            currencyList.Add(gbp);

            return currencyList;
        }

        //Запрос данных с сайта CBR
        private async Task<XDocument> GetCBRData(DateTime date)
        {
            //Дата для запроса
            string formatDate = date.Date.ToString("dd'/'MM'/'yyyy");
            // Адрес сайта с курсом валюты
            Uri uri = new Uri($"http://www.cbr.ru/scripts/XML_daily.asp?date_req={formatDate}");
            string xml = string.Empty;

            //Получаем данные по курсу валют с сайта         
            HttpClient client = new HttpClient();
            using (client)
            {
                xml = await client.GetStringAsync(uri);
            }

            //Переводим полученные данные в формат XML
            XDocument xdoc = XDocument.Parse(xml);

            return xdoc;
        }


        //Получить данные с Coingate
        private async Task<List<Currency>> GetCoingateRate()
        {
            string usdRUB = "USD/RUB";
            string eurRub = "EUR/RUB";
            string cnyRub = "CNY/RUB";
            string gbpRub = "GBP/RUB";

            List<Currency> currencyList = new List<Currency>();

            Currency usd = new Currency(await ParseCoingateRait(usdRUB), 1);
            currencyList.Add(usd);
            Currency eur = new Currency(await ParseCoingateRait(eurRub), 2);
            currencyList.Add(eur);
            Currency cny = new Currency(await ParseCoingateRait(cnyRub), 3);
            currencyList.Add(cny);
            Currency gbp = new Currency(await ParseCoingateRait(gbpRub), 4);
            currencyList.Add(gbp);

            return currencyList;
        }

        //Запрос данных с Coingate.com
        private async Task<string> ParseCoingateRait(string currencyPair)
        {
            string url = $"https://api.coingate.com/v2/rates/merchant/{currencyPair}";

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)await myHttpWebRequest.GetResponseAsync();
            StreamReader myStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
            string result = await myStreamReader.ReadToEndAsync();

            return result;
        }


        public string GetRatesText(List<Currency> currencyList)
        {
            string result = string.Empty;

            foreach (var cur in currencyList)
            {
                result += cur.GetFullData() + "\n";
            }

            return result;
        }

        private async void parseToday_button_Click(object sender, EventArgs e)
        {           
            ExchangesRate_TextBox.Text = $"Курс из ЦБР:\n{ GetRatesText(await GetCBRRate(DateTime.Today))}";
            ExchangesRate_TextBox.Text += $"\nКурс из coingate:\n{GetRatesText(await GetCoingateRate())}";           
        }

        private async void parseOnDate_button_Click(object sender, EventArgs e)
        {
            DateTime date = info_dateTimePicker.Value;
            ExchangesRate_TextBox.Text = $"Курс из ЦБР на {date.ToShortDateString()}:\n{GetRatesText(await GetCBRRate(date))}";
        }

        //Получение записи из БД и создание в случае отсутсвия
        private async Task GetCurrencyFromDB(int[] idArray, DateTime date)
        {
            DB db = new DB();
            string formattedDate = date.ToString("yyyy'-'MM'-'dd");        
            db.OpenConnection();

            List < Currency > currencyList = await GetCBRRate(date);

            db_dialog_richTextBox.Clear();

            foreach (var id in idArray)
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand($"SELECT * FROM `currencyvalue` WHERE `CurrencyNameId` = {id} AND `Date` = '{formattedDate}'", db.GetConnection());
                MySqlDataReader reader = (MySqlDataReader)(await command.ExecuteReaderAsync());

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Currency cur = new Currency(reader["Value"].ToString(), Int32.Parse(reader["CurrencyNameId"].ToString()));
                        db_dialog_richTextBox.Text += $"{cur.GetFullData()} \n";
                      
                    }
                    reader.Close();
                }
                else
                {
                    await CreateCurrencyInDB(currencyList.Where(c => c.Id == id).FirstOrDefault(), date);
                }
                db.CloseConnection();
            }
          

        }

        //Создание записи в БД
        private async Task CreateCurrencyInDB(Currency cur, DateTime date)
        {
            try
            {
                DB db = new DB();
                string formattedDate = date.ToString("yyyy'-'MM'-'dd");
                string formattedValue = $"{cur.Value.Split(',')[0]}.{cur.Value.Split(',')[1]}";
                MySqlCommand command = new MySqlCommand($"INSERT INTO `currencyvalue` (`id`, `CurrencyNameId`, `SourceNameId`, `Date`, `Value`) VALUES(NULL, '{cur.Id}', '1', '{formattedDate}', '{formattedValue}')", db.GetConnection());

                db.OpenConnection();

                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    db_dialog_richTextBox.Text += $"\n Запись {cur.Name} на {date.ToString("dd.MM.yyyy")} успешно создана";
                }
                else
                {
                    db_dialog_richTextBox.Text += $"\n Запись {cur.Name} на {date.ToString("dd.MM.yyyy")} ошибка создания";
                }
                db.CloseConnection();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private async void get_from_db_button_Click(object sender, EventArgs e)
        {            
            int[] idArray = new int[]{1,2,3,4};
            DateTime date = db_dateTimePicker.Value;

            await GetCurrencyFromDB(idArray, date);         
        }

        private void chart_button_Click(object sender, EventArgs e)
        {
            Charts charts_form = new Charts();
            charts_form.Show();
        }
    }
}

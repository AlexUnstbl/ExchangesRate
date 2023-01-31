using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangesRate
{
    public partial class Charts : Form
    {
        //MainForm main_form = new MainForm();

        public Charts()
        {
            InitializeComponent();
        }

        //Возвращеает список дат за предыдущую неделю
        private List<DateTime> GetDateList()
        {
            List < DateTime > dateList = new List<DateTime>();
            int dayCnt = 0;

            if (period_comboBox.SelectedIndex == 0)
            {
                dayCnt = 7;
            }
            if (period_comboBox.SelectedIndex == 1)
            {
                dayCnt = 14;
            }

            for (int i = 0; i <= dayCnt ; i++)
            {
                dateList.Add(DateTime.Now.AddDays(-i));
            }

            return dateList;
        }

        //Получить список валют в определённую дату
        private async Task<List<Currency>> GetCurrencyListOnDate(DateTime date)
        {
            int[] idArray = new int[] { 1, 2, 3, 4 };
            DB db = new DB();
            string formattedDate = date.ToString("yyyy'-'MM'-'dd");
            List<Currency> currencyList = new List<Currency>();

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
                        currencyList.Add(cur);
                    }
                    reader.Close();
                }

                db.CloseConnection();
            }

            return currencyList;
        }

        private void AcceptChartsSetting()
        {
            setChartSetting(usd_chart);
            setChartSetting(eur_chart);
            setChartSetting(cny_chart);
            setChartSetting(gbp_chart);
        }

        private void ClearCharts()
        {
            usd_chart.Series[0].Points.Clear();
            eur_chart.Series[0].Points.Clear();
            cny_chart.Series[0].Points.Clear();
            gbp_chart.Series[0].Points.Clear();
        }


        //Применяем настройки к графикам
        private void setChartSetting(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series[0].Points.Clear();

            if (chart == usd_chart)
            {
                chart.ChartAreas[0].AxisY.Minimum = 50.00;
                chart.ChartAreas[0].AxisY.Maximum = 80.00;
            }
            else if (chart == cny_chart)
            {
                chart.ChartAreas[0].AxisY.Minimum = 9.00;
                chart.ChartAreas[0].AxisY.Maximum = 15.00;
            }
            else if (chart == eur_chart)
            {
                chart.ChartAreas[0].AxisY.Minimum = 50.00;
                chart.ChartAreas[0].AxisY.Maximum = 100.00;
            }
            else if (chart == gbp_chart)
            {
                chart.ChartAreas[0].AxisY.Minimum = 60.00;
                chart.ChartAreas[0].AxisY.Maximum = 100.00;
            }

            chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yyyy";
            chart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

            if (period_comboBox.SelectedIndex == 0)
            {
                chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddDays(-7).ToOADate();
            }
            if (period_comboBox.SelectedIndex == 1)
            {
                chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddDays(-14).ToOADate();
            }
           
            chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.ToOADate();

            chart.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chart.ChartAreas[0].AxisX.Interval = 1;
        }

        //Добавляет точки на график
        private void AddChartsPoint(List<Currency> currencyList, DateTime date)
        {
            usd_chart.Series[0].Points.AddXY(date, double.Parse(currencyList[0].Value));
            eur_chart.Series[0].Points.AddXY(date, double.Parse(currencyList[1].Value));
            cny_chart.Series[0].Points.AddXY(date, double.Parse(currencyList[2].Value));
            gbp_chart.Series[0].Points.AddXY(date, double.Parse(currencyList[3].Value));
        }


        private void SetPeriodComboBoxSetting()
        {
            period_comboBox.Items.Clear();
            period_comboBox.Items.Add("1 неделя");
            period_comboBox.Items.Add("2 недели");
            period_comboBox.SelectedIndex = 0;
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            AcceptChartsSetting();
            SetPeriodComboBoxSetting();
        }

        private async Task CreateCurrencyGraphics()
        {
            List<DateTime> dateList = GetDateList();
            foreach (var date in dateList)
            {
                List<Currency> currencyList = await GetCurrencyListOnDate(date);
                AddChartsPoint(currencyList, date);
            }
        }

        private async void period_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcceptChartsSetting();
            await CreateCurrencyGraphics();            
        }
    }
}

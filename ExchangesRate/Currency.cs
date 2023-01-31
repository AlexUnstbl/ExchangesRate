using System.Collections.Generic;

namespace ExchangesRate
{
    public class Currency
    {
        public string Name;
        public string Value;
        public int Id;

        Dictionary<int, string> names = new Dictionary<int, string>()
        {
            {1, "Доллар США"},
            {2, "Евро"},
            {3, "Китайский юань" },
            {4, "Фунт стерлингов" }
        };

        #region ID List
        /*USD = 1
          EUR = 2 
          CNY = 3 
          GBP = 4 */
        #endregion

        public Currency(string value, int id)
        {
            Name = GetName(id);
            Value = value;
            Id = id;
        }

        public string GetFullData()
        {
            return $"{this.Name} {this.Value} руб.";
        }

        public string GetName(int id)
        {
            return names[id];
        }
    }
}

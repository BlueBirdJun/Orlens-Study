using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblExchangeRate
    {
        public int Idx { get; set; }
        public string Sitename { get; set; }
        public string CountryLangCd { get; set; }
        public string CurrencyUnit { get; set; }
        public string CurrencyChar { get; set; }
        public decimal ExchangeRate { get; set; }
        public double Multiplerate { get; set; }
        public int? LinkPriceType { get; set; }
        public string Basedate { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Reguserid { get; set; }
        public string Lastuserid { get; set; }
    }
}

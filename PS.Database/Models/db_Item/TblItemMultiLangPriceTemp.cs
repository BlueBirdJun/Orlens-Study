using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemMultiLangPriceTemp
    {
        public string Sitename { get; set; }
        public int Itemid { get; set; }
        public string CurrencyUnit { get; set; }
        public decimal Orgprice { get; set; }
        public decimal Wonprice { get; set; }
        public decimal? MaydiscountPrice { get; set; }
        public decimal? LastexchangeRate { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Reguserid { get; set; }
        public string Lastuserid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblMonthlyBrandInfo
    {
        public string Yyyymm { get; set; }
        public string Makerid { get; set; }
        public int ItemCountTtl { get; set; }
        public int ItemCountM { get; set; }
        public int ItemCountW { get; set; }
        public int ItemCountU { get; set; }
        public int ItemCountTtlsale { get; set; }
        public int ItemCountMsale { get; set; }
        public int ItemCountWsale { get; set; }
        public int ItemCountUsale { get; set; }
        public decimal? Defaultdeliverpay { get; set; }
        public decimal? Defaultfreebeasonglimit { get; set; }
        public string DefaultDeliveryType { get; set; }
        public int? SellType { get; set; }
        public string Groupid { get; set; }
        public string DefaultOnMwDiv { get; set; }
        public double? DefaultOnMargin { get; set; }
        public double? MMargin { get; set; }
        public double? WMargin { get; set; }
        public double? UMargin { get; set; }
        public int? StockAreaBox { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

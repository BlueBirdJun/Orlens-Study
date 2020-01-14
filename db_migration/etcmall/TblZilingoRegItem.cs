using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblZilingoRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? ZilingoRegdate { get; set; }
        public DateTime? ZilingoLastUpdate { get; set; }
        public string ZilingoGoodNo { get; set; }
        public decimal ZilingoPrice { get; set; }
        public string ZilingoSellYn { get; set; }
        public int ZilingoStatCd { get; set; }
        public int? RctSellCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public string RegImageName { get; set; }
        public int? EditQuecnt { get; set; }
        public decimal? RegOrgprice { get; set; }
        public double? Multiplerate { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Itemoption { get; set; }
        public int? Quantity { get; set; }
    }
}

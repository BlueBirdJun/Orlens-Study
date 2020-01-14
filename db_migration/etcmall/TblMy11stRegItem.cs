using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblMy11stRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public string TransItemname { get; set; }
        public DateTime? My11stRegdate { get; set; }
        public DateTime? My11stLastUpdate { get; set; }
        public string My11stGoodNo { get; set; }
        public decimal My11stPrice { get; set; }
        public string My11stSellYn { get; set; }
        public int My11stStatCd { get; set; }
        public DateTime? LastOptConfirmdate { get; set; }
        public int? RctSellCnt { get; set; }
        public int? RegedOptCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
        public string RegImageName { get; set; }
        public int? EditQuecnt { get; set; }
        public decimal? RegOrgprice { get; set; }
        public double? Multiplerate { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}

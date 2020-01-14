using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblGsshopAddoptionRegitem
    {
        public int Midx { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? GsshopRegdate { get; set; }
        public DateTime? GsshopLastUpdate { get; set; }
        public string GsshopGoodNo { get; set; }
        public decimal? GsshopPrice { get; set; }
        public string GsshopSellYn { get; set; }
        public int? GsshopStatCd { get; set; }
        public DateTime? Lastconfirmdate { get; set; }
        public int? RctSellCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public int? EditQueCnt { get; set; }
    }
}

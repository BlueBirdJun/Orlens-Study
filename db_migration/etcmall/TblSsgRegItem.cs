using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblSsgRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? SsgRegdate { get; set; }
        public DateTime? SsgLastUpdate { get; set; }
        public string SsgGoodNo { get; set; }
        public decimal SsgPrice { get; set; }
        public decimal? SsgFirstPrice { get; set; }
        public string SsgSellYn { get; set; }
        public int SsgStatCd { get; set; }
        public DateTime? Lastconfirmdate { get; set; }
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
        public string DisplayDate { get; set; }
        public int? SetMargin { get; set; }
    }
}

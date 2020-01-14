using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHalfclubRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? HalfclubRegdate { get; set; }
        public DateTime? HalfclubLastUpdate { get; set; }
        public string HalfclubGoodNo { get; set; }
        public decimal HalfclubPrice { get; set; }
        public string HalfclubSellYn { get; set; }
        public int HalfclubStatCd { get; set; }
        public DateTime? LastConfirmdate { get; set; }
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
    }
}

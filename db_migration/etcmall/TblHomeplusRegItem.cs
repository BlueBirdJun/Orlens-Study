using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHomeplusRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? HomeplusRegdate { get; set; }
        public DateTime? HomeplusLastUpdate { get; set; }
        public string HomeplusGoodNo { get; set; }
        public decimal HomeplusPrice { get; set; }
        public string HomeplusSellYn { get; set; }
        public int HomeplusStatCd { get; set; }
        public DateTime? LastConfirmdate { get; set; }
        public int? RctSellCnt { get; set; }
        public int? RegedOptCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
    }
}

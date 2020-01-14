using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHmallRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? HmallRegdate { get; set; }
        public DateTime? HmallLastUpdate { get; set; }
        public string HmallGoodNo { get; set; }
        public string HmallGoodNo2 { get; set; }
        public decimal HmallPrice { get; set; }
        public string HmallSellYn { get; set; }
        public int HmallStatCd { get; set; }
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
        public string ApiaddImg { get; set; }
        public int? SetMargin { get; set; }
        public string ApiconfirmImg { get; set; }
    }
}

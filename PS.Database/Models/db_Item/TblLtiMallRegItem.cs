using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblLtiMallRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? LtiMallRegdate { get; set; }
        public DateTime? LtiMallLastUpdate { get; set; }
        public string LtiMallGoodNo { get; set; }
        public string LtiMallTmpGoodNo { get; set; }
        public decimal LtiMallPrice { get; set; }
        public string LtiMallSellYn { get; set; }
        public int LtiMallStatCd { get; set; }
        public DateTime? LastConfirmdate { get; set; }
        public int? RctSellCnt { get; set; }
        public int? RegedOptCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
        public int? EditQueCnt { get; set; }
        public int? DispViewCnt { get; set; }
    }
}

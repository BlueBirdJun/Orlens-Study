using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblLotteRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? LotteRegdate { get; set; }
        public DateTime? LotteLastUpdate { get; set; }
        public int? LotteGoodNo { get; set; }
        public int? LotteTmpGoodNo { get; set; }
        public decimal LottePrice { get; set; }
        public string LotteSellYn { get; set; }
        public string LotteStatCd { get; set; }
        public DateTime? LastConfirmdate { get; set; }
        public int? RctSellCnt { get; set; }
        public int? RegedOptCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public DateTime? ItemTableUpdateChkdate { get; set; }
        public string Regitemname { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
        public DateTime? TnLastupdate { get; set; }
        public int? EditQueCnt { get; set; }
        public DateTime? LastcateChgDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblEzwelRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? EzwelRegdate { get; set; }
        public DateTime? EzwelLastUpdate { get; set; }
        public string EzwelGoodNo { get; set; }
        public decimal EzwelPrice { get; set; }
        public string EzwelSellYn { get; set; }
        public int EzwelStatCd { get; set; }
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
    }
}

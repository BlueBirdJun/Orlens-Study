using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblCoupangRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? CoupangRegdate { get; set; }
        public DateTime? CoupangLastUpdate { get; set; }
        public string CoupangGoodNo { get; set; }
        public decimal CoupangPrice { get; set; }
        public string CoupangSellYn { get; set; }
        public int CoupangStatCd { get; set; }
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
        public string ProductId { get; set; }
        public string FirstVendorItemId { get; set; }
    }
}

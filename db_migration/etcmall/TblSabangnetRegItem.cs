using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblSabangnetRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? SabangnetRegdate { get; set; }
        public DateTime? SabangnetLastUpdate { get; set; }
        public string SabangnetGoodNo { get; set; }
        public decimal SabangnetPrice { get; set; }
        public string SabangnetSellYn { get; set; }
        public int SabangnetStatCd { get; set; }
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
        public string Apiadditem { get; set; }
        public string Apiaddopt { get; set; }
        public string Apiaddgosi { get; set; }
        public DateTime? OnSaleRegdate { get; set; }
        public int? EditQuecnt { get; set; }
    }
}

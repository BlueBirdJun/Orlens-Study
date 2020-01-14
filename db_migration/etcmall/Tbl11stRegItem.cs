using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class Tbl11stRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? St11Regdate { get; set; }
        public DateTime? St11LastUpdate { get; set; }
        public string St11GoodNo { get; set; }
        public decimal St11Price { get; set; }
        public string St11SellYn { get; set; }
        public int St11StatCd { get; set; }
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
        public DateTime? SaleRegdate { get; set; }
        public int? EditQuecnt { get; set; }
    }
}

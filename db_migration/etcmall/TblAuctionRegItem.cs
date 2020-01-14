using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblAuctionRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? AuctionRegdate { get; set; }
        public DateTime? AuctionLastUpdate { get; set; }
        public string AuctionGoodNo { get; set; }
        public decimal AuctionPrice { get; set; }
        public string AuctionSellYn { get; set; }
        public int AuctionStatCd { get; set; }
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

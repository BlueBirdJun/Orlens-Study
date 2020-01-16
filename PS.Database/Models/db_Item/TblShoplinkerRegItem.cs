using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblShoplinkerRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? ShoplinkerRegdate { get; set; }
        public DateTime? ShoplinkerLastUpdate { get; set; }
        public string ShoplinkerGoodNo { get; set; }
        public decimal ShoplinkerPrice { get; set; }
        public string ShoplinkerSellYn { get; set; }
        public int ShoplinkerStatCd { get; set; }
        public DateTime? LastConfirmdate { get; set; }
        public int? RctSellCnt { get; set; }
        public int? RegedOptCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
        public string InsertInfoCd { get; set; }
        public string ShoplinkerOutMallConnect { get; set; }
    }
}

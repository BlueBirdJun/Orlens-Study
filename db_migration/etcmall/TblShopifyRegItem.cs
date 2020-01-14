using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblShopifyRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? ShopifyRegdate { get; set; }
        public DateTime? ShopifyLastUpdate { get; set; }
        public string ShopifyGoodNo { get; set; }
        public string Shopifyhandle { get; set; }
        public decimal ShopifyPrice { get; set; }
        public string ShopifySellYn { get; set; }
        public int ShopifyStatCd { get; set; }
        public int? RctSellCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public string RegImageName { get; set; }
        public int? EditQuecnt { get; set; }
        public decimal? RegOrgprice { get; set; }
        public double? Multiplerate { get; set; }
        public decimal? ExchangeRate { get; set; }
        public int? Quantity { get; set; }
        public string ProductType { get; set; }
    }
}

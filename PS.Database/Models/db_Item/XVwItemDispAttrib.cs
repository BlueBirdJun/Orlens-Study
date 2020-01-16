using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class XVwItemDispAttrib
    {
        public long Catecode { get; set; }
        public int CateSortNo { get; set; }
        public string IsDefault { get; set; }
        public string Itemdiv { get; set; }
        public int Itemid { get; set; }
        public string Itemname { get; set; }
        public decimal Sellcash { get; set; }
        public decimal OrgPrice { get; set; }
        public decimal? SalePercent { get; set; }
        public decimal? SalePrice { get; set; }
        public string Makerid { get; set; }
        public string BrandName { get; set; }
        public string BasicImage { get; set; }
        public string MaskImage { get; set; }
        public string ListImage { get; set; }
        public string ListImage120 { get; set; }
        public string SmallImage { get; set; }
        public string Icon1Image { get; set; }
        public string Icon2Image { get; set; }
        public string Sellyn { get; set; }
        public string AttribCd { get; set; }
        public string SaleYn { get; set; }
        public string LimitYn { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? ReipgoDate { get; set; }
        public string ItemCouponYn { get; set; }
        public int? ItemCouponValue { get; set; }
        public string ItemCouponType { get; set; }
        public string TenOnlyYn { get; set; }
        public int EvalCnt { get; set; }
        public int? EvalCntPhoto { get; set; }
        public int Favcount { get; set; }
        public int? ItemScore { get; set; }
        public string KeyWords { get; set; }
        public int Stritemid { get; set; }
        public string NewYn { get; set; }
        public string Deliverytype { get; set; }
        public string IsFreeBeasong { get; set; }
        public string IsAboard { get; set; }
        public string StyleCd { get; set; }
        public string ColorCd { get; set; }
        public short CateDepth { get; set; }
        public string Cd1 { get; set; }
        public string Cd2 { get; set; }
        public string Cd3 { get; set; }
        public string Catename { get; set; }
        public string IsBestBrand { get; set; }
        public string AttribName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteJungsanTmp
    {
        public string Sellsite { get; set; }
        public string ExtOrderserial { get; set; }
        public string ExtOrderserSeq { get; set; }
        public string ExtOrgOrderserial { get; set; }
        public string ExtVatYn { get; set; }
        public int ExtItemNo { get; set; }
        public decimal ExtItemCost { get; set; }
        public decimal ExtReducedPrice { get; set; }
        public decimal ExtOwnCouponPrice { get; set; }
        public decimal ExtTenCouponPrice { get; set; }
        public string ExtJungsanType { get; set; }
        public decimal ExtCommPrice { get; set; }
        public decimal ExtCommSupplyPrice { get; set; }
        public decimal ExtCommSupplyVatPrice { get; set; }
        public decimal ExtTenMeachulPrice { get; set; }
        public decimal ExtTenMeachulSupplyPrice { get; set; }
        public decimal ExtTenMeachulSupplyVatPrice { get; set; }
        public decimal ExtTenJungsanPrice { get; set; }
        public string ExtMeachulDate { get; set; }
        public string ExtJungsanDate { get; set; }
        public string OrgOrderserial { get; set; }
        public int? Itemid { get; set; }
        public string Itemoption { get; set; }
        public string ExtItemName { get; set; }
        public string ExtItemOptionName { get; set; }
        public string ExtItemId { get; set; }
        public string ExtItemOption { get; set; }
        public string SiteNo { get; set; }
    }
}

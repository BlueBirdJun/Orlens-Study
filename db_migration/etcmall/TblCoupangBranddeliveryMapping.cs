using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblCoupangBranddeliveryMapping
    {
        public string Makerid { get; set; }
        public string VendorId { get; set; }
        public string ShippingPlaceName { get; set; }
        public string Global { get; set; }
        public string AddressType { get; set; }
        public string CountryCode { get; set; }
        public string CompanyContactNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public string ReturnZipCode { get; set; }
        public string ReturnAddress { get; set; }
        public string ReturnAddressDetail { get; set; }
        public string DeliveryCode { get; set; }
        public decimal? Jeju { get; set; }
        public decimal? NotJeju { get; set; }
        public string OutboundShippingPlaceCode { get; set; }
        public DateTime Regdate { get; set; }
    }
}

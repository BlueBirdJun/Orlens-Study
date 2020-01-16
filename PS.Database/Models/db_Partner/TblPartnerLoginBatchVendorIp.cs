using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerLoginBatchVendorIp
    {
        public string Refip { get; set; }
        public string Vendor { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Validdate { get; set; }
    }
}

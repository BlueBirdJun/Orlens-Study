using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblCoupangRegedoption
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string VendorItemId { get; set; }
        public string SellerProductItemId { get; set; }
        public string OutmallOptName { get; set; }
        public string OutmallSellyn { get; set; }
        public string Outmalllimityn { get; set; }
        public int Outmalllimitno { get; set; }
        public decimal OutmallAddPrice { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? Checkdate { get; set; }
    }
}

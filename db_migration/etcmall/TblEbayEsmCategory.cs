using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblEbayEsmCategory
    {
        public string SdcategoryCode { get; set; }
        public string ParentSdcategoryCode { get; set; }
        public string SdcategoryName { get; set; }
        public string SdcategoryName2 { get; set; }
        public string Lv { get; set; }
        public DateTime Regdate { get; set; }
    }
}

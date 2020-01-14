using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblEbayCateMapping
    {
        public string SdcategoryCode { get; set; }
        public string CateCode { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Gubun { get; set; }
    }
}

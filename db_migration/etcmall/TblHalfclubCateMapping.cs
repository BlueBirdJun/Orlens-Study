using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHalfclubCateMapping
    {
        public string DepthCode { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public string BrandCode { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

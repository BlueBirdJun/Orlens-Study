using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class Tbl11stCateMapping
    {
        public int DepthCode { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

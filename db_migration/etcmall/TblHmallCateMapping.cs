using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHmallCateMapping
    {
        public string CateKey { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Teninfodiv { get; set; }
        public int? Num { get; set; }
    }
}

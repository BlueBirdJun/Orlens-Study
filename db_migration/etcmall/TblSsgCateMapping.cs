using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblSsgCateMapping
    {
        public string StdCtgDclsCd { get; set; }
        public string DepthCode { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public string SiteNo { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

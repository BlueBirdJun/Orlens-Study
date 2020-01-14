using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHomeplusPrdDivMapping
    {
        public string HDivision { get; set; }
        public string HGroup { get; set; }
        public string HDept { get; set; }
        public string HClass { get; set; }
        public string HSubclass { get; set; }
        public string HCategoryId { get; set; }
        public string Infodiv { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

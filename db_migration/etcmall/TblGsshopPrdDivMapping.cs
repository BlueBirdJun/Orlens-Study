using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblGsshopPrdDivMapping
    {
        public string Divcode { get; set; }
        public string Infodiv { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Safecode { get; set; }
        public string Isvat { get; set; }
    }
}

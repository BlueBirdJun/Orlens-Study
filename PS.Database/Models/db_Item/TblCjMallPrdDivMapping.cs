using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblCjMallPrdDivMapping
    {
        public string CddKey { get; set; }
        public string Infodiv { get; set; }
        public string CdmKey { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}

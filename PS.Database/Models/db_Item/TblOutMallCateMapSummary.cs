using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblOutMallCateMapSummary
    {
        public string Mallid { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public int MapCnt { get; set; }
    }
}

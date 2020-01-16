using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblBetweenProjectGroup
    {
        public int PjtgroupCode { get; set; }
        public int PjtCode { get; set; }
        public string PjtgroupDesc { get; set; }
        public byte PjtgroupSort { get; set; }
        public string PjtgroupBgcolor { get; set; }
        public string PjtgroupFontColor { get; set; }
        public int? PjtgroupPcode { get; set; }
        public int? PjtgroupDepth { get; set; }
        public string PjtgroupUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

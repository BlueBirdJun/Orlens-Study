using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartInfo
    {
        public int PartSn { get; set; }
        public string PartName { get; set; }
        public int PartSort { get; set; }
        public string PartIsDel { get; set; }
    }
}

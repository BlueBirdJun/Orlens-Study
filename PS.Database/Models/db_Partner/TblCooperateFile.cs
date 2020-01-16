using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateFile
    {
        public int FileIdx { get; set; }
        public int DocIdx { get; set; }
        public int BrdSn { get; set; }
        public string FileName { get; set; }
        public string RealName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateLog
    {
        public int LogIdx { get; set; }
        public int DocIdx { get; set; }
        public byte LogType { get; set; }
        public string LogContent { get; set; }
        public string LogIp { get; set; }
        public DateTime LogRegdate { get; set; }
    }
}

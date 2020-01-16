using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblQrcodeLog
    {
        public int LogSn { get; set; }
        public int QrSn { get; set; }
        public string RefIp { get; set; }
        public string DevDiv { get; set; }
        public DateTime Regdate { get; set; }
        public string BrowserInfo { get; set; }
    }
}

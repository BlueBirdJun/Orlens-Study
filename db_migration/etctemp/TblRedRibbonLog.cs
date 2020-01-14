using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblRedRibbonLog
    {
        public decimal LogSn { get; set; }
        public string Userid { get; set; }
        public DateTime Regdate { get; set; }
        public string WinYn { get; set; }
        public string RedItemid { get; set; }
    }
}

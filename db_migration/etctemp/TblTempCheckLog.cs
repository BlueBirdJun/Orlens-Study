using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblTempCheckLog
    {
        public int Idx { get; set; }
        public string Val { get; set; }
        public string RefIp { get; set; }
        public DateTime Regdate { get; set; }
    }
}

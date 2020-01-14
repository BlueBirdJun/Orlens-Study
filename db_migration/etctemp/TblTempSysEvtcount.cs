using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblTempSysEvtcount
    {
        public int Idx { get; set; }
        public string Name { get; set; }
        public string Evtname { get; set; }
        public DateTime Regdate { get; set; }
    }
}

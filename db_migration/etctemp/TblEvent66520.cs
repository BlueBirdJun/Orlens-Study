using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEvent66520
    {
        public int Idx { get; set; }
        public int? EvtCode { get; set; }
        public string Userid { get; set; }
        public string SubOpt1 { get; set; }
        public int? SubOpt2 { get; set; }
        public string SubOpt3 { get; set; }
        public DateTime Regdate { get; set; }
        public string Device { get; set; }
    }
}

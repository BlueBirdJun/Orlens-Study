using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEventAttendance
    {
        public int Idx { get; set; }
        public int? EvtCode { get; set; }
        public string Userid { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

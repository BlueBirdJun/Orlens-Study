using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEventClickLog
    {
        public int Idx { get; set; }
        public string Eventid { get; set; }
        public string Chkid { get; set; }
        public int? Temp1 { get; set; }
        public DateTime Regdate { get; set; }
    }
}

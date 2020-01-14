using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblWaitItemLog
    {
        public int LogIdx { get; set; }
        public int Itemid { get; set; }
        public string Currstate { get; set; }
        public string Logmsgcd { get; set; }
        public string Logmsg { get; set; }
        public DateTime? Regdate { get; set; }
        public string Adminid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallIni
    {
        public string Mallid { get; set; }
        public string Inikey { get; set; }
        public string IniVal { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

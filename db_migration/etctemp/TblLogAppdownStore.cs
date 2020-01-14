using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblLogAppdownStore
    {
        public int Idx { get; set; }
        public string Store { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblNateScraplog
    {
        public int Idx { get; set; }
        public DateTime? Regdate { get; set; }
        public string Ref { get; set; }
    }
}

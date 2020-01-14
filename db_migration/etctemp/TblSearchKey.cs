using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblSearchKey
    {
        public int Idx { get; set; }
        public string Keyword { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

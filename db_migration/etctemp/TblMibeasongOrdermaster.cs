using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMibeasongOrdermaster
    {
        public int Idx { get; set; }
        public int Boxno { get; set; }
        public string Orderserial { get; set; }
        public DateTime? Regdate { get; set; }
        public string WorkGroup { get; set; }
    }
}

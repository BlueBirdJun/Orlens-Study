using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblGs25nfcInfo
    {
        public int Idx { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string Hp { get; set; }
        public string Stat { get; set; }
        public string Div { get; set; }
        public string CpAuthNo { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}

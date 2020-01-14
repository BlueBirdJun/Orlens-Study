using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblNaverItemMap
    {
        public int Tenitemid { get; set; }
        public long? Naveritemid { get; set; }
        public long? Matchnvmid { get; set; }
        public string Serviceyn { get; set; }
        public DateTime Regdate { get; set; }
    }
}

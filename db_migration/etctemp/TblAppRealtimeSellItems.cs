using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblAppRealtimeSellItems
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public DateTime Selldate { get; set; }
        public DateTime Regdate { get; set; }
        public int Orderno { get; set; }
    }
}

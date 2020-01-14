using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblWishEventUserfolder
    {
        public int Idx { get; set; }
        public int? Fidx { get; set; }
        public string Userid { get; set; }
        public int? Viewcnt { get; set; }
        public DateTime? Regdate { get; set; }
        public int? EvtCode { get; set; }
    }
}

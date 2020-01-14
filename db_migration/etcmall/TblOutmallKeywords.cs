using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallKeywords
    {
        public int Idx { get; set; }
        public string Mallid { get; set; }
        public int Itemid { get; set; }
        public string Keywords { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TrgTblUserC
    {
        public long Logidx { get; set; }
        public string Userid { get; set; }
        public string TrgMode { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

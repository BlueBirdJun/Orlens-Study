using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblInfinitystaticHistory
    {
        public int Idx { get; set; }
        public int? Mainidx { get; set; }
        public string Userid { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

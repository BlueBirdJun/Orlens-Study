using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEventItemwish
    {
        public int Idx { get; set; }
        public int EvtCode { get; set; }
        public int Itemid { get; set; }
        public int Gubun { get; set; }
        public DateTime Regdate { get; set; }
        public string Userid { get; set; }
        public string Device { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEvent16thPickshow
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public int EvtCode { get; set; }
        public int EvtSubCode { get; set; }
        public int Pickitem1 { get; set; }
        public int Pickitem2 { get; set; }
        public int Pickitem3 { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

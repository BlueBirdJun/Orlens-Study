using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEvent45262
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public short Nowtime { get; set; }
        public string IsClear { get; set; }
        public string Value { get; set; }
        public DateTime Regdate { get; set; }
    }
}

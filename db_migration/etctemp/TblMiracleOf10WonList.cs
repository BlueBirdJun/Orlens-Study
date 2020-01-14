using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMiracleOf10WonList
    {
        public int Idx { get; set; }
        public string EvtCode { get; set; }
        public string Userid { get; set; }
        public string Usercell { get; set; }
        public int? Userlevel { get; set; }
        public int? Roundnum { get; set; }
        public string Kakaochk { get; set; }
        public decimal? Lprice { get; set; }
        public int? Prizecode { get; set; }
        public string Prizename { get; set; }
        public DateTime? Regdate { get; set; }
        public string Device { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblAutoPush
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public int EvtCode { get; set; }
        public DateTime SendDate { get; set; }
        public string SendStatus { get; set; }
        public DateTime? RegDate { get; set; }
    }
}

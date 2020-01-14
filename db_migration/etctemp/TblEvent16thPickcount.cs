using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEvent16thPickcount
    {
        public int EvtCode { get; set; }
        public int EvtSubCode { get; set; }
        public int Itemid { get; set; }
        public int Pickcount { get; set; }
    }
}

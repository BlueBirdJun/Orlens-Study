using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblSafetycertInboundTemp
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string CertNum { get; set; }
        public string SafetyDiv { get; set; }
        public string State { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

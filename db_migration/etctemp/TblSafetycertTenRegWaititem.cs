using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblSafetycertTenRegWaititem
    {
        public int Itemid { get; set; }
        public string CertNum { get; set; }
        public string SafetyDiv { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteTmpcsTimestamp
    {
        public string SellSite { get; set; }
        public string CsGubun { get; set; }
        public DateTime? LastCheckDate { get; set; }
        public string IsSuccess { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}

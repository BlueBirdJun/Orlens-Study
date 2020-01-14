using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteTmporderTimestamp
    {
        public string SellSite { get; set; }
        public DateTime? LastCheckDate { get; set; }
        public string IsSuccess { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}

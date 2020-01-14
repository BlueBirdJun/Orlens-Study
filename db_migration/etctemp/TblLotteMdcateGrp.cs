using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblLotteMdcateGrp
    {
        public int GroupCode { get; set; }
        public string Mdcode { get; set; }
        public string SuperGroupName { get; set; }
        public string GroupName { get; set; }
        public DateTime LastUpdate { get; set; }
        public string IsUsing { get; set; }
    }
}

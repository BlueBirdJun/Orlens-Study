using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblRelaymileInfo
    {
        public int Relaymileidx { get; set; }
        public string Yyyymm { get; set; }
        public string Userid { get; set; }
        public byte RelayCount { get; set; }
        public decimal OrderTotal { get; set; }
        public string IsComplete { get; set; }
        public DateTime? CompleteDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string IsPay { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string IsUsing { get; set; }
    }
}

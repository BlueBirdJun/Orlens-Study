using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMemoryUsage
    {
        public int Idx { get; set; }
        public DateTime Inputdate { get; set; }
        public string CounterName { get; set; }
        public string CntrValue { get; set; }
        public decimal Gb { get; set; }
    }
}

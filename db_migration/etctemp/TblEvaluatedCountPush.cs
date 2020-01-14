using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEvaluatedCountPush
    {
        public int Idx { get; set; }
        public int Pushidx { get; set; }
        public int ReviewCount { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

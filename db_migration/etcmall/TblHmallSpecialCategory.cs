using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHmallSpecialCategory
    {
        public int Idx { get; set; }
        public string Depth1Name { get; set; }
        public string Depth2Name { get; set; }
        public int SectId1 { get; set; }
        public int SectId2 { get; set; }
    }
}

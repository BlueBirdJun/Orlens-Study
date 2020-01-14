using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblJaehumallHopeSellLog
    {
        public int Idx { get; set; }
        public string Mallgubun { get; set; }
        public string Makerid { get; set; }
        public string HopeStr { get; set; }
        public string UseYn { get; set; }
        public string Reguserid { get; set; }
        public DateTime Regdate { get; set; }
    }
}

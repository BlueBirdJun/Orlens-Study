using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblJaehumallHopeSell
    {
        public int Idx { get; set; }
        public string Makerid { get; set; }
        public string Mallgubun { get; set; }
        public string IsComplete { get; set; }
        public int Currstat { get; set; }
        public string Hopesellstat { get; set; }
        public string Whyhope { get; set; }
        public string AdminText { get; set; }
        public DateTime Hoperegdate { get; set; }
        public DateTime? AdminRegdate { get; set; }
    }
}

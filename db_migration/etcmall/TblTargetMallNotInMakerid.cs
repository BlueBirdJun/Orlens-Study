using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblTargetMallNotInMakerid
    {
        public int Idx { get; set; }
        public string Makerid { get; set; }
        public string Mallgubun { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
    }
}

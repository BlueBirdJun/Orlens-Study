using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblJungsanTmp
    {
        public string Yyyymm { get; set; }
        public string Makerid { get; set; }
        public string Mwgubun { get; set; }
        public int? Cnt { get; set; }
        public int? Execcnt { get; set; }
        public string Execok { get; set; }
    }
}

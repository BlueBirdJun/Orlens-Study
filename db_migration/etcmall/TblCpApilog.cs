using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblCpApilog
    {
        public int Idx { get; set; }
        public string Gubun { get; set; }
        public string Cpid { get; set; }
        public string Makerid { get; set; }
        public string Certkey { get; set; }
        public string Xmldata { get; set; }
        public DateTime? Regdate { get; set; }
        public string Refip { get; set; }
    }
}

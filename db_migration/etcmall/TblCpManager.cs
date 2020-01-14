using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblCpManager
    {
        public int Idx { get; set; }
        public string Cpid { get; set; }
        public string Makerid { get; set; }
        public string Certkey { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

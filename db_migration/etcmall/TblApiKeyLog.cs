using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblApiKeyLog
    {
        public int Idx { get; set; }
        public string Gubun { get; set; }
        public string Makerid { get; set; }
        public string ApiKey { get; set; }
        public string Xmldata { get; set; }
        public DateTime? Regdate { get; set; }
        public string Refip { get; set; }
    }
}

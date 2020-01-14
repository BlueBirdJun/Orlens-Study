using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblWemakeCategory2
    {
        public int Idx { get; set; }
        public string CateKey { get; set; }
        public string Depth1Name { get; set; }
        public string Depth2Name { get; set; }
        public string Depth3Name { get; set; }
        public string Depth4Name { get; set; }
        public string Isusing { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string SafeCertTrgtYn { get; set; }
    }
}

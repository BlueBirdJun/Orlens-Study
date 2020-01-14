using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHmallCategory
    {
        public int Idx { get; set; }
        public string CateKey { get; set; }
        public string Depth1Name { get; set; }
        public string Depth2Name { get; set; }
        public string Depth3Name { get; set; }
        public string Depth4Name { get; set; }
        public string Depth5Name { get; set; }
        public string Depth6Name { get; set; }
        public string Isusing { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string QaTrgtYn { get; set; }
        public string SafeCertTrgtYn { get; set; }
        public string CoreMngYn { get; set; }
        public string ItstDlbrYn { get; set; }
        public string InfNotfBsicCd { get; set; }
        public string SafeCertTypeGbcd { get; set; }
    }
}

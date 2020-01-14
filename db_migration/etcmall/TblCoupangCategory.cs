using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblCoupangCategory
    {
        public int CateKey { get; set; }
        public string Depth1Name { get; set; }
        public string Depth2Name { get; set; }
        public string Depth3Name { get; set; }
        public string Depth4Name { get; set; }
        public string Depth5Name { get; set; }
        public string Depth6Name { get; set; }
        public string Isusing { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string IsAllowSingleItem { get; set; }
    }
}

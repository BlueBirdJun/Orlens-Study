using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEtcSpecial
    {
        public string Sitename { get; set; }
        public string Itemid { get; set; }
        public string Dispnum { get; set; }
        public string Disptitle { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

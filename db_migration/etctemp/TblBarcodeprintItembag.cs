using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblBarcodeprintItembag
    {
        public int Bagidx { get; set; }
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public int Itemno { get; set; }
        public string Userid { get; set; }
        public string Shopid { get; set; }
        public DateTime Regdate { get; set; }
        public string Onoffgubun { get; set; }
    }
}

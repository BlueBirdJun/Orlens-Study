using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMibeasongSum
    {
        public int Idx { get; set; }
        public string Makerid { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Itemname { get; set; }
        public string Itemoptionname { get; set; }
        public int Itemno { get; set; }
        public string Orderserial { get; set; }
        public string Realorderserial { get; set; }
        public DateTime? Lastupdate { get; set; }
        public int? Itemlackno { get; set; }
    }
}

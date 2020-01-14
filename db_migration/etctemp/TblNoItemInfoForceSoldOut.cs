using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblNoItemInfoForceSoldOut
    {
        public int Itemid { get; set; }
        public string Itemsellyn { get; set; }
        public DateTime? SoldoutDate { get; set; }
        public DateTime? ResellDate { get; set; }
    }
}

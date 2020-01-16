using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemRelation
    {
        public int MainItemid { get; set; }
        public int SubItemid { get; set; }
    }
}

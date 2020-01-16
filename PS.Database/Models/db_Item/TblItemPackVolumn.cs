using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemPackVolumn
    {
        public int Itemid { get; set; }
        public double VolX { get; set; }
        public double VolY { get; set; }
        public double VolZ { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdt { get; set; }
    }
}

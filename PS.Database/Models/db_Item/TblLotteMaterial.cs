using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblLotteMaterial
    {
        public string Mallid { get; set; }
        public string MallinfoDiv { get; set; }
        public int Itemid { get; set; }
        public string Material { get; set; }
        public DateTime Regdate { get; set; }
    }
}

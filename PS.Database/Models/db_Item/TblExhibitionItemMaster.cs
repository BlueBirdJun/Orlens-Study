using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblExhibitionItemMaster
    {
        public int Idx { get; set; }
        public int Mastercode { get; set; }
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public int Itemscore { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblExhibitionItemDetail2
    {
        public int Idx { get; set; }
        public int Mastercode { get; set; }
        public int Gubuncode { get; set; }
        public int Itemid { get; set; }
        public string Optioncode { get; set; }
        public int Detailcode { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public byte Isusing { get; set; }
    }
}

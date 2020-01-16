using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblExhibitioneventGroupcode
    {
        public int Gidx { get; set; }
        public int Gubuncode { get; set; }
        public int Mastercode { get; set; }
        public int Detailcode { get; set; }
        public string Typename { get; set; }
        public string Type { get; set; }
        public DateTime Regdate { get; set; }
        public byte Isusing { get; set; }
    }
}

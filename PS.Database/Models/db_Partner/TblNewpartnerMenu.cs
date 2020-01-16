using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblNewpartnerMenu
    {
        public int Idx { get; set; }
        public int Depth { get; set; }
        public int Depth1 { get; set; }
        public int? Depth2 { get; set; }
        public int? Depth3 { get; set; }
        public string Depth1name { get; set; }
        public string Depth2name { get; set; }
        public string Depth3name { get; set; }
        public string Linkurl { get; set; }
        public int? Viewidx { get; set; }
        public int Divcd { get; set; }
        public string Explanation { get; set; }
        public string Isusing { get; set; }
    }
}

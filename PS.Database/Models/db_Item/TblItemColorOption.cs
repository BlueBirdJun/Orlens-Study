using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemColorOption
    {
        public int Itemid { get; set; }
        public int ColorCode { get; set; }
        public string BasicImage { get; set; }
        public string BasicImage600 { get; set; }
        public string Icon1image { get; set; }
        public string Listimage120 { get; set; }
        public string Listimage { get; set; }
        public string Icon2image { get; set; }
        public string Smallimage { get; set; }
        public DateTime? Regdate { get; set; }
        public string Itemoption { get; set; }
        public string BasicImage1000 { get; set; }
    }
}

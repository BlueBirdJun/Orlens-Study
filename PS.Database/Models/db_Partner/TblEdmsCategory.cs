using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEdmsCategory
    {
        public int Categoryidx { get; set; }
        public int Catedepth { get; set; }
        public string Catename { get; set; }
        public string Catecode { get; set; }
        public int Pcateidx { get; set; }
        public bool? IsUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

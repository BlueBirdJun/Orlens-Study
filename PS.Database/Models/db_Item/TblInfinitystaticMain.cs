using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblInfinitystaticMain
    {
        public int Idx { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Kind { get; set; }
        public string Contents { get; set; }
        public string Parameter { get; set; }
        public string Regid { get; set; }
        public string Flag { get; set; }
        public DateTime? Updatedate { get; set; }
        public DateTime Createdate { get; set; }
    }
}

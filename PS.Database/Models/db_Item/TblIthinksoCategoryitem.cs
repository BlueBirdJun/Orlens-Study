using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblIthinksoCategoryitem
    {
        public int CateDispSeq { get; set; }
        public int CateTypeSeq { get; set; }
        public int Itemid { get; set; }
        public int CateSeq1 { get; set; }
        public int CateSeq2 { get; set; }
        public int CateSeq3 { get; set; }
        public string IsUsing { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

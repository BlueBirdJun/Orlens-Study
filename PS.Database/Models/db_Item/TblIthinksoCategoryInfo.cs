using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblIthinksoCategoryInfo
    {
        public int CateSeq { get; set; }
        public int CateTypeSeq { get; set; }
        public int SubCateSeq1 { get; set; }
        public int SubCateSeq2 { get; set; }
        public int Depth { get; set; }
        public string CateName { get; set; }
        public int CateOrder { get; set; }
        public string IsUsing { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

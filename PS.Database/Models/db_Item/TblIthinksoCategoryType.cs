using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblIthinksoCategoryType
    {
        public int CateTypeSeq { get; set; }
        public string CateTypeName { get; set; }
        public int CateTypeOrder { get; set; }
        public string IsUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

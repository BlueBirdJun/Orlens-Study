using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblCateRelateLink
    {
        public int LinkCode { get; set; }
        public string CodeLarge { get; set; }
        public string CodeMid { get; set; }
        public string CodeSmall { get; set; }
        public string LinkKeyword { get; set; }
        public string LinkUrl { get; set; }
    }
}

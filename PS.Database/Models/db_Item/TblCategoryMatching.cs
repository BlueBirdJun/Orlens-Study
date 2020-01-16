using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblCategoryMatching
    {
        public int Matchidx { get; set; }
        public long Catecode { get; set; }
        public string CodeLarge { get; set; }
        public string CodeMid { get; set; }
        public string CodeSmall { get; set; }
        public bool? IsUsing { get; set; }
        public string AdminId { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TrgTblItemContents
    {
        public long Logidx { get; set; }
        public int Itemid { get; set; }
        public int? Favcount { get; set; }
        public string TrgMode { get; set; }
        public DateTime? Logdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblDisplayCateItem
    {
        public long Catecode { get; set; }
        public int Itemid { get; set; }
        public short Depth { get; set; }
        public int SortNo { get; set; }
        public string IsDefault { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblBetweenCateItem
    {
        public long Catecode { get; set; }
        public int Itemid { get; set; }
        public short Depth { get; set; }
        public int SortNo { get; set; }
        public string IsDefault { get; set; }
        public string ChgItemname { get; set; }
        public DateTime Regdate { get; set; }
        public int? RctSellCnt { get; set; }
        public string Isdisplay { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblColorChips
    {
        public int ColorCode { get; set; }
        public string ColorName { get; set; }
        public string ColorIcon { get; set; }
        public int SortNo { get; set; }
        public string IsUsing { get; set; }
    }
}

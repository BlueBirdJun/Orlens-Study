using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblMakeglobCategory
    {
        public int MgCateCd { get; set; }
        public short Depth { get; set; }
        public string CateNm { get; set; }
        public int ParentCd { get; set; }
        public short SortNo { get; set; }
        public string IsUsing { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

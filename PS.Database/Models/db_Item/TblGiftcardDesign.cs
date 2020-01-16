using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblGiftcardDesign
    {
        public int DesignId { get; set; }
        public int CardItemid { get; set; }
        public string GroupDiv { get; set; }
        public string CardDesignName { get; set; }
        public string Mmsthumb { get; set; }
        public string Mmsimage { get; set; }
        public string Mmstext { get; set; }
        public string EmailThumb { get; set; }
        public string EmailImage { get; set; }
        public string EmailText { get; set; }
        public string IsUsing { get; set; }
        public int SortNo { get; set; }
    }
}

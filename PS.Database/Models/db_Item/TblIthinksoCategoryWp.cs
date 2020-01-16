using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblIthinksoCategoryWp
    {
        public int CateInfoSeq { get; set; }
        public string ItemserialLarge { get; set; }
        public string ItemserialMid { get; set; }
        public string ItemserialSmall { get; set; }
        public string CateInfoImg { get; set; }
        public bool? IsUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

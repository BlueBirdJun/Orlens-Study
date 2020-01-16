using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemInfoCode
    {
        public string InfoCd { get; set; }
        public string InfoDiv { get; set; }
        public string InfoDivName { get; set; }
        public string InfoItemName { get; set; }
        public string InfoDesc { get; set; }
        public string InfoType { get; set; }
        public int InfoSort { get; set; }
        public string InfoReq { get; set; }
        public string IsUsing { get; set; }
    }
}

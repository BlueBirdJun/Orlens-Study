using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemInfoDiv
    {
        public string InfoDiv { get; set; }
        public string InfoDivName { get; set; }
        public int InfoValidCnt { get; set; }
        public string SafetyTargetYn { get; set; }
        public string SafetyCertYn { get; set; }
        public string SafetyConfirmYn { get; set; }
        public string SafetySupplyYn { get; set; }
        public string SafetyComply { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Lastadminid { get; set; }
        public string IsUsing { get; set; }
    }
}

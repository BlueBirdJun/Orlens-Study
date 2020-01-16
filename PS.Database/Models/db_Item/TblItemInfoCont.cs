using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemInfoCont
    {
        public int Itemid { get; set; }
        public string InfoCd { get; set; }
        public string ChkDiv { get; set; }
        public string InfoContent { get; set; }
        public DateTime? LastinputDt { get; set; }
    }
}

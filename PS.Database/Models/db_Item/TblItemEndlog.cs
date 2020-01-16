using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemEndlog
    {
        public int Itemid { get; set; }
        public byte Endtype { get; set; }
        public DateTime Regdate { get; set; }
        public string Adminid { get; set; }
    }
}

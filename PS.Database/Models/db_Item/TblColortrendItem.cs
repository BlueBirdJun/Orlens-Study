using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblColortrendItem
    {
        public int Idx { get; set; }
        public int ColorCode { get; set; }
        public int Itemid { get; set; }
        public int Orderno { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

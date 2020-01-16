using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblAgirlRegItem
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public int AgirlItemSeq { get; set; }
        public string AgirlOptionCode { get; set; }
        public byte LinkStockType { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemSellReserve
    {
        public int Itemid { get; set; }
        public DateTime Sellreservedate { get; set; }
        public DateTime? Sellstartdate { get; set; }
        public string Regid { get; set; }
        public DateTime? Canceldate { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

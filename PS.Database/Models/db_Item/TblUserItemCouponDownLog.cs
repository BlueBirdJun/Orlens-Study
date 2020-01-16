using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblUserItemCouponDownLog
    {
        public int Logidx { get; set; }
        public int Downidx { get; set; }
        public string Userid { get; set; }
        public int Itemid { get; set; }
        public int? Itemcouponidx { get; set; }
        public int? Couponidx { get; set; }
        public DateTime Regdt { get; set; }
    }
}

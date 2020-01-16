using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemCouponDetail
    {
        public int Itemcouponidx { get; set; }
        public int Itemid { get; set; }
        public decimal Couponbuyprice { get; set; }
        public double? Couponmargin { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblUserItemCoupon
    {
        public long Couponidx { get; set; }
        public string Userid { get; set; }
        public int Itemcouponidx { get; set; }
        public int? Issuedno { get; set; }
        public string Itemcoupontype { get; set; }
        public decimal? Itemcouponvalue { get; set; }
        public DateTime? Itemcouponstartdate { get; set; }
        public DateTime? Itemcouponexpiredate { get; set; }
        public string Itemcouponname { get; set; }
        public string Itemcouponimage { get; set; }
        public DateTime? Regdate { get; set; }
        public string Usedyn { get; set; }
        public string Orderserial { get; set; }
        public string CouponGubun { get; set; }
    }
}

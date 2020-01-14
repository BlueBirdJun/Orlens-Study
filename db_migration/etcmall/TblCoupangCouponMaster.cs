using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblCoupangCouponMaster
    {
        public int Idx { get; set; }
        public string CouponName { get; set; }
        public int MaxDiscountPrice { get; set; }
        public int Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CouponType { get; set; }
        public string RequestedId { get; set; }
        public string CouponId { get; set; }
        public DateTime Regdate { get; set; }
    }
}

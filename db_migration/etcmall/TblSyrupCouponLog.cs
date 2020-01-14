using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblSyrupCouponLog
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public int Couponidx { get; set; }
        public DateTime Regdate { get; set; }
    }
}

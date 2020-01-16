﻿using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblTagCouponMaster
    {
        public int Idx { get; set; }
        public string Coupontype { get; set; }
        public int Couponvalue { get; set; }
        public string Couponname { get; set; }
        public string Tagstr { get; set; }
        public int Minbuyprice { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Openfinishdate { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Expiredate { get; set; }
        public string Etcstr { get; set; }
        public string Isusing { get; set; }
        public string Isopenlistcoupon { get; set; }
        public string Validsitename { get; set; }
        public string TargetCpnType { get; set; }
        public string TargetCpnSource { get; set; }
        public int MxCpnDiscount { get; set; }
    }
}

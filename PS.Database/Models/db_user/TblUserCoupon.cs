using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserCoupon
    {
        public int Idx { get; set; }
        public int Masteridx { get; set; }
        public string Userid { get; set; }
        public string Coupontype { get; set; }
        public int Couponvalue { get; set; }
        public string Couponname { get; set; }
        public int? Minbuyprice { get; set; }
        public string Targetitemlist { get; set; }
        public string Couponimage { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Expiredate { get; set; }
        public string Isusing { get; set; }
        public string Deleteyn { get; set; }
        public string Orderserial { get; set; }
        public int? Exitemid { get; set; }
        public string Validsitename { get; set; }
        public string Notvalid10x10 { get; set; }
        public decimal? Couponmeaipprice { get; set; }
        public string Ssnkey { get; set; }
        public int? Scratchcouponidx { get; set; }
        public string Reguserid { get; set; }
        public int? EvtprizeCode { get; set; }
        public int? UseLevel { get; set; }
        public string Csorderserial { get; set; }
        public string TargetCpnType { get; set; }
        public string TargetCpnSource { get; set; }
        public int? MxCpnDiscount { get; set; }
    }
}

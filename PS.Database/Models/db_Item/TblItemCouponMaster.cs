using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemCouponMaster
    {
        public int Itemcouponidx { get; set; }
        public string CouponGubun { get; set; }
        public int? EvtCode { get; set; }
        public int? EvtgroupCode { get; set; }
        public string Itemcoupontype { get; set; }
        public decimal? Itemcouponvalue { get; set; }
        public DateTime? Itemcouponstartdate { get; set; }
        public DateTime? Itemcouponexpiredate { get; set; }
        public string Itemcouponname { get; set; }
        public string Itemcouponimage { get; set; }
        public string Itemcouponexplain { get; set; }
        public int? Applyitemcount { get; set; }
        public string Openstate { get; set; }
        public string Margintype { get; set; }
        public DateTime? Regdate { get; set; }
        public string Reguserid { get; set; }
        public short Defaultmargin { get; set; }
        public string Coupontype { get; set; }
        public DateTime? LastupDt { get; set; }
    }
}

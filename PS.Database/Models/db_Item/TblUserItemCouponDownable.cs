using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblUserItemCouponDownable
    {
        public int Downidx { get; set; }
        public string Userid { get; set; }
        public int Itemid { get; set; }
        public DateTime Expirestartdt { get; set; }
        public DateTime Expireenddt { get; set; }
        public string Downstate { get; set; }
        public string Itemcoupontype { get; set; }
        public decimal? Itemcouponvalue { get; set; }
        public decimal? Couponbuyprice { get; set; }
        public short? Defaultmargin { get; set; }
        public string Margintype { get; set; }
        public byte Regtype { get; set; }
        public DateTime Regdt { get; set; }
    }
}

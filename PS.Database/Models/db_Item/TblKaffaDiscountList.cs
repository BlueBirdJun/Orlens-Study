using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblKaffaDiscountList
    {
        public int DiscountKey { get; set; }
        public string DiscountTitle { get; set; }
        public int PromotionType { get; set; }
        public DateTime StDt { get; set; }
        public DateTime EdDt { get; set; }
        public double DiscountPro { get; set; }
        public int DiscountbuyRule { get; set; }
        public double DiscountbuyPro { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string RegUserId { get; set; }
        public string LastUpUserId { get; set; }
    }
}

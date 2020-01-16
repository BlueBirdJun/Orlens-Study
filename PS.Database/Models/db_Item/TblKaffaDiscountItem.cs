using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblKaffaDiscountItem
    {
        public int DiscountKey { get; set; }
        public int Itemid { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal? DiscountbuyMoney { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string RegUserId { get; set; }
        public string LastUpUserId { get; set; }
    }
}

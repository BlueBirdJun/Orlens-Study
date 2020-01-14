using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblWishlistEvent
    {
        public string Userid { get; set; }
        public int Itemid { get; set; }
        public int Fidx { get; set; }
        public string CateLarge { get; set; }
        public decimal Sellcash { get; set; }
        public string Sellyn { get; set; }
        public decimal Orgprice { get; set; }
        public string Itemcouponyn { get; set; }
        public int? Curritemcouponidx { get; set; }
        public string Itemcoupontype { get; set; }
        public DateTime Regdate { get; set; }
        public int EvtCode { get; set; }
    }
}

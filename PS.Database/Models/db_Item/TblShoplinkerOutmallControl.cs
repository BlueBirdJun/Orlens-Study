using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblShoplinkerOutmallControl
    {
        public string Makerid { get; set; }
        public string MallUserId { get; set; }
        public string MallName { get; set; }
        public decimal? DefaultFreeBeasongLimit { get; set; }
        public decimal? DefaultDeliverPay { get; set; }
    }
}

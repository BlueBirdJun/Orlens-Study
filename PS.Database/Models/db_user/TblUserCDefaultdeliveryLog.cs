using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserCDefaultdeliveryLog
    {
        public decimal Idx { get; set; }
        public string Userid { get; set; }
        public decimal? DefaultFreeBeasongLimit { get; set; }
        public decimal? DefaultDeliverPay { get; set; }
        public string DefaultDeliveryType { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

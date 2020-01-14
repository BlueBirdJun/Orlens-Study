using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblLotteMdinfo
    {
        public string Mdcode { get; set; }
        public string Mdname { get; set; }
        public string SellFeeType { get; set; }
        public string NormalSellFee { get; set; }
        public string EventSellFee { get; set; }
        public DateTime LastUpdate { get; set; }
        public string IsUsing { get; set; }
    }
}

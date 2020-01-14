using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblNvsMinprofitLog
    {
        public int Itemid { get; set; }
        public string Sailyn { get; set; }
        public decimal Sellcash { get; set; }
        public decimal Buycash { get; set; }
        public decimal Nvsprice { get; set; }
        public int Couponamt { get; set; }
        public string Status { get; set; }
        public string Pendingyn { get; set; }
        public DateTime Regdate { get; set; }
    }
}

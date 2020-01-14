using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblJust1DayShinhan
    {
        public string JustDate { get; set; }
        public int Itemid { get; set; }
        public decimal OrgPrice { get; set; }
        public decimal JustSalePrice { get; set; }
        public decimal SaleSuplyCash { get; set; }
        public string JustDesc { get; set; }
        public int LimitNo { get; set; }
        public int LimitSold { get; set; }
        public string IsUsing { get; set; }
        public DateTime Regdate { get; set; }
        public string Adminid { get; set; }
    }
}

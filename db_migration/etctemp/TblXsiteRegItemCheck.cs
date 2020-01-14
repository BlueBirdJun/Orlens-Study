using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXsiteRegItemCheck
    {
        public string SellSite { get; set; }
        public string Goodsno { get; set; }
        public string SaleStatCd { get; set; }
        public decimal SalePrc { get; set; }
        public string GoodsNm { get; set; }
        public DateTime GoodsRegDtime { get; set; }
        public string DispYn { get; set; }
        public DateTime RegDtKey { get; set; }
        public int? MayTenItemId { get; set; }
        public int? Maymidx { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMonthlyAccumulatedShopstockSummaryBuf
    {
        public string Shopid { get; set; }
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Yyyymm { get; set; }
        public int? Logicsipgono { get; set; }
        public int? Logicsreipgono { get; set; }
        public int? Brandipgono { get; set; }
        public int? Brandreipgono { get; set; }
        public int? Sellno { get; set; }
        public int? Resellno { get; set; }
        public int? Errsampleitemno { get; set; }
        public int? Errbaditemno { get; set; }
        public int? Errrealcheckno { get; set; }
        public int? Sysstockno { get; set; }
        public int? Realstockno { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string LstCommCd { get; set; }
        public decimal? LstBuyCash { get; set; }
        public decimal? LstSuplycash { get; set; }
        public string LstMakerid { get; set; }
    }
}

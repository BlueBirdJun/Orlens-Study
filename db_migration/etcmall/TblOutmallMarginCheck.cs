using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallMarginCheck
    {
        public int Idx { get; set; }
        public string Sellsite { get; set; }
        public string Orderserial { get; set; }
        public string Makerid { get; set; }
        public int? Itemid { get; set; }
        public string Itemoption { get; set; }
        public decimal? Itemcost { get; set; }
        public decimal? Buycash { get; set; }
        public string Mwdiv { get; set; }
        public string Issailitem { get; set; }
        public int? Margin { get; set; }
        public int? Brand2MonthMargin { get; set; }
        public decimal? Optaddprice { get; set; }
        public decimal? Optaddbuyprice { get; set; }
        public decimal? ItemcostCouponNotApplied { get; set; }
        public decimal? BuycashCouponNotApplied { get; set; }
        public decimal? NowselladdoptCost { get; set; }
        public decimal? Nowselladdoptbuycash { get; set; }
        public decimal? NowDiffCost { get; set; }
        public decimal? NowDiffbuycash { get; set; }
        public decimal? Logbuycash { get; set; }
        public DateTime? LogbuycashDate { get; set; }
        public decimal? LogDiffbuycash { get; set; }
        public decimal? MinusPrice { get; set; }
        public decimal? Minusbuycash { get; set; }
        public string Etc1 { get; set; }
        public string Etc2 { get; set; }
        public string OptaddpriceYn { get; set; }
        public string ChkDate { get; set; }
        public DateTime? Regdate { get; set; }
        public string IsOk { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallDiffOrder
    {
        public int Idx { get; set; }
        public string Sellsite { get; set; }
        public int Itemid { get; set; }
        public string Makerid { get; set; }
        public string Sellyn { get; set; }
        public string Limityn { get; set; }
        public int? Limitno { get; set; }
        public int? Limitsold { get; set; }
        public string Optsellyn { get; set; }
        public string Optlimityn { get; set; }
        public int? Optlimitno { get; set; }
        public int? Optlimitsold { get; set; }
        public decimal Sellcash { get; set; }
        public decimal? Optaddprice { get; set; }
        public string Matchitemoption { get; set; }
        public decimal Outmallsellprice { get; set; }
        public decimal? DiffPrice { get; set; }
        public string OutMallGoodsNo { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime? Regdate { get; set; }
        public string IsOk { get; set; }
    }
}

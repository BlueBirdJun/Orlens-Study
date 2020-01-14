using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteTmpcheckItemStat
    {
        public int OutmallOrderSeq { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public decimal Sellcash { get; set; }
        public decimal Orgprice { get; set; }
        public string Sellyn { get; set; }
        public string Limityn { get; set; }
        public int Limitno { get; set; }
        public int Limitsold { get; set; }
        public string Optsellyn { get; set; }
        public string Optlimityn { get; set; }
        public int Optlimitno { get; set; }
        public int Optlimitsold { get; set; }
        public decimal Optaddprice { get; set; }
        public decimal Optaddbuyprice { get; set; }
        public string Itemname { get; set; }
        public string Optiontypename { get; set; }
        public string Optionname { get; set; }
        public DateTime Regdate { get; set; }
        public string Sellsite { get; set; }
        public string MallGoodsNo { get; set; }
        public decimal? TmpOrderSellPrice { get; set; }
        public int? MapErrType { get; set; }
        public int? MapErrType2 { get; set; }
        public int? MapErrType3 { get; set; }
        public string MallSnapSellyn { get; set; }
        public decimal? MallSnapSellprice { get; set; }
        public string MallSnapStatcd { get; set; }
        public DateTime? MallSnapLastUpDt { get; set; }
        public DateTime? MallSnapLastCheckDt { get; set; }
        public DateTime? MallSnapDt { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMonthlyAccumulatedLogisstockSummaryBuf
    {
        public string Yyyymm { get; set; }
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public int? Ipgono { get; set; }
        public int? Reipgono { get; set; }
        public int? Totipgono { get; set; }
        public int? Offchulgono { get; set; }
        public int? Offrechulgono { get; set; }
        public int? Etcchulgono { get; set; }
        public int? Etcrechulgono { get; set; }
        public int? Totchulgono { get; set; }
        public int? Sellno { get; set; }
        public int? Resellno { get; set; }
        public int? Totsellno { get; set; }
        public int? Errcsno { get; set; }
        public int? Errbaditemno { get; set; }
        public int? Errrealcheckno { get; set; }
        public int? Erretcno { get; set; }
        public int? Toterrno { get; set; }
        public int? Offsellno { get; set; }
        public int? Totsysstock { get; set; }
        public int? Availsysstock { get; set; }
        public int? Realstock { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Lastmwdiv { get; set; }
        public decimal? AvgipgoPrice { get; set; }
        public decimal? LastbuyPrice { get; set; }
        public int? Lossno { get; set; }
        public string Lastmakerid { get; set; }
        public string TargetGbn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOpExpDaily
    {
        public int OpExpDailyIdx { get; set; }
        public string Yyyymmdd { get; set; }
        public int OpExpPartIdx { get; set; }
        public decimal? ArapCd { get; set; }
        public int? CommCd { get; set; }
        public int? AccountIdx { get; set; }
        public decimal InExp { get; set; }
        public decimal OutExp { get; set; }
        public decimal? SupExp { get; set; }
        public decimal? VatExp { get; set; }
        public string OpExpObj { get; set; }
        public string AuthNo { get; set; }
        public string DetailConts { get; set; }
        public int? UseOpExpPartIdx { get; set; }
        public string BizSectionCd { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Regid { get; set; }
        public bool? IsUsing { get; set; }
        public decimal? BusiIdx { get; set; }
        public string ErpLinkSeq { get; set; }
    }
}

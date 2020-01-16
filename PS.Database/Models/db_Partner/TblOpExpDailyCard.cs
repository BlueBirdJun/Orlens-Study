using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOpExpDailyCard
    {
        public int OpExpDailyCardIdx { get; set; }
        public string Yyyymm { get; set; }
        public DateTime? AuthDate { get; set; }
        public int? OpExpPartIdx { get; set; }
        public decimal? ArapCd { get; set; }
        public decimal? OutExp { get; set; }
        public decimal? SupExp { get; set; }
        public decimal? VatExp { get; set; }
        public decimal? SevExp { get; set; }
        public string AuthNo { get; set; }
        public string OpExpObj { get; set; }
        public string DetailConts { get; set; }
        public string BizsectionCd { get; set; }
        public string VatType { get; set; }
        public bool? DeductType { get; set; }
        public string BizNo { get; set; }
        public byte? UseScope { get; set; }
        public string AccCd { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Regid { get; set; }
        public bool? IsUsing { get; set; }
        public string ErpLinkSeq { get; set; }
        public int? CardTmpSeq { get; set; }
    }
}

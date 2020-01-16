using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppReport
    {
        public int ReportIdx { get; set; }
        public int EdmsIdx { get; set; }
        public decimal? ArapCd { get; set; }
        public int? AccountIdx { get; set; }
        public string ReportName { get; set; }
        public decimal ReportPrice { get; set; }
        public int? ScmlinkNo { get; set; }
        public string Bigo { get; set; }
        public string ReportContents { get; set; }
        public byte ReportState { get; set; }
        public string ReferId { get; set; }
        public string AdminId { get; set; }
        public DateTime Regdate { get; set; }
        public bool? IsUsing { get; set; }
        public byte? Paytype { get; set; }
        public string Currencytype { get; set; }
        public decimal? Currencyprice { get; set; }
        public byte? LastApprovalid { get; set; }
    }
}

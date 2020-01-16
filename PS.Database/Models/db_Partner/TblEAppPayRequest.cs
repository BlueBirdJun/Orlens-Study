using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppPayRequest
    {
        public int PayRequestidx { get; set; }
        public byte? PayRequestType { get; set; }
        public int ReportIdx { get; set; }
        public string PayRequestTitle { get; set; }
        public decimal? ArapCd { get; set; }
        public DateTime? PayRequestdate { get; set; }
        public decimal PayRequestPrice { get; set; }
        public string CustCd { get; set; }
        public string InBank { get; set; }
        public string AccountNo { get; set; }
        public string AccountHolder { get; set; }
        public DateTime? Paydate { get; set; }
        public byte? OutBank { get; set; }
        public DateTime? PayRealdate { get; set; }
        public string Yyyymm { get; set; }
        public bool IsTakeDoc { get; set; }
        public string AdminId { get; set; }
        public byte PayRequestState { get; set; }
        public string Comment { get; set; }
        public byte? Paytype { get; set; }
        public string Currencytype { get; set; }
        public decimal? Currencyprice { get; set; }
        public DateTime Regdate { get; set; }
        public bool? IsUsing { get; set; }
        public string ErpLinkType { get; set; }
        public string ErpLinkKey { get; set; }
    }
}

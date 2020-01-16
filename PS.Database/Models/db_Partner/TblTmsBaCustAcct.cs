using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblTmsBaCustAcct
    {
        public string CustCd { get; set; }
        public string BankCd { get; set; }
        public string AcctNo { get; set; }
        public string UseYn { get; set; }
        public string ArapType { get; set; }
        public string AcctNickNm { get; set; }
        public string SavMn { get; set; }
        public string CmsCd { get; set; }
        public string VacctYn { get; set; }
        public string SanYn { get; set; }
        public string SanId { get; set; }
        public string SanDt { get; set; }
        public string ReqId { get; set; }
        public string ReqDt { get; set; }
        public decimal? DispSeq { get; set; }
        public string ModUser { get; set; }
        public string ModDt { get; set; }
        public string Bigo { get; set; }
        public string DelYn { get; set; }
        public DateTime? BitchkDt { get; set; }
        public string DefAcctYn { get; set; }
        public string RefSavDt { get; set; }
        public string RefSavNm { get; set; }
        public string CustType { get; set; }
    }
}

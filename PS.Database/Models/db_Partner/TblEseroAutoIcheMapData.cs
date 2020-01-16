using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEseroAutoIcheMapData
    {
        public int AutoIcheIdx { get; set; }
        public int MatchType { get; set; }
        public int TaxSellType { get; set; }
        public string CorpNo { get; set; }
        public string CustCd { get; set; }
        public string AutoIcheTitle { get; set; }
        public decimal? MayPrice { get; set; }
        public string MayAcctDate { get; set; }
        public string MayPumok { get; set; }
        public string MayIcheDate { get; set; }
        public string MayAcctJukyo { get; set; }
        public string AssignBizSec { get; set; }
        public int? AssignArapCd { get; set; }
    }
}

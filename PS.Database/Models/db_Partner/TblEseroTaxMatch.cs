using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEseroTaxMatch
    {
        public string TaxKey { get; set; }
        public int MatchSeq { get; set; }
        public int MatchType { get; set; }
        public int MatchKey { get; set; }
        public int MatchState { get; set; }
        public string BizSecCd { get; set; }
        public string ErpLinkType { get; set; }
        public string ErpLinkKey { get; set; }
    }
}

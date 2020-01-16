using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerContractDetailType
    {
        public int ContractType { get; set; }
        public string DetailKey { get; set; }
        public string DetailDesc { get; set; }
        public int Orderno { get; set; }
    }
}

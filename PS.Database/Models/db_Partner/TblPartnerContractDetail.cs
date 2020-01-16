using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerContractDetail
    {
        public int ContractId { get; set; }
        public string DetailKey { get; set; }
        public string DetailValue { get; set; }
    }
}

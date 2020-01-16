using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerContractType
    {
        public int ContractType { get; set; }
        public string ContractName { get; set; }
        public string ContractContents { get; set; }
        public string Isusing { get; set; }
        public DateTime? Regdate { get; set; }
        public string Onoffgubun { get; set; }
        public int SubType { get; set; }
    }
}

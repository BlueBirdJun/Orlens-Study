using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerContract
    {
        public int ContractId { get; set; }
        public string Makerid { get; set; }
        public int ContractType { get; set; }
        public int ContractState { get; set; }
        public string ContractName { get; set; }
        public string ContractNo { get; set; }
        public string ContractContents { get; set; }
        public string ContractEtcContetns { get; set; }
        public string Reguserid { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Confirmdate { get; set; }
        public DateTime? Finishdate { get; set; }
    }
}

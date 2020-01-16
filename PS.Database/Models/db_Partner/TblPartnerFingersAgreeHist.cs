using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerFingersAgreeHist
    {
        public int AgreeIdx { get; set; }
        public int ContractType { get; set; }
        public string Groupid { get; set; }
        public string Makerid { get; set; }
        public DateTime? Viewdate { get; set; }
        public DateTime? Agreedate { get; set; }
        public string AgreeRefIp { get; set; }
        public string ContractNo { get; set; }
        public string ContractContents { get; set; }
        public DateTime? Deldate { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

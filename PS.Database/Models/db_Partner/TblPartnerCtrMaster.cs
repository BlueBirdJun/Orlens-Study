using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerCtrMaster
    {
        public int CtrKey { get; set; }
        public int ContractType { get; set; }
        public string Groupid { get; set; }
        public string Makerid { get; set; }
        public int CtrState { get; set; }
        public string CtrNo { get; set; }
        public string RegUserId { get; set; }
        public string SendUserId { get; set; }
        public string FinUserId { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Senddate { get; set; }
        public DateTime? Confirmdate { get; set; }
        public DateTime? Finishdate { get; set; }
        public DateTime? Deletedate { get; set; }
        public string ContractContents { get; set; }
        public DateTime? Renewdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? EcctrSeq { get; set; }
        public string EcAuser { get; set; }
        public string EcBuser { get; set; }
        public DateTime? Lastupdate { get; set; }
        public DateTime? Ecupdate { get; set; }
    }
}

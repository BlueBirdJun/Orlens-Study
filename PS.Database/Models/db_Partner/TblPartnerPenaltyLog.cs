using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerPenaltyLog
    {
        public int Idx { get; set; }
        public string Makerid { get; set; }
        public string Partgubun { get; set; }
        public string Penaltygubun { get; set; }
        public string Penaltyname { get; set; }
        public DateTime Penaltydate { get; set; }
        public int Penaltyvalue { get; set; }
        public string Detailcontents { get; set; }
        public string Reguser { get; set; }
        public DateTime? Regdate { get; set; }
        public int? Linkitemid { get; set; }
        public string Linkorderserial { get; set; }
        public string Deleteyn { get; set; }
        public string Deluser { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerLoginRejectIp
    {
        public string Refip { get; set; }
        public DateTime RejectExpDt { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public int RjtCnt { get; set; }
    }
}

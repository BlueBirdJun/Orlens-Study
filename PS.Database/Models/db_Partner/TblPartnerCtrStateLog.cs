using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerCtrStateLog
    {
        public int Ctrlogidx { get; set; }
        public int Ctrkey { get; set; }
        public byte Logtype { get; set; }
        public string Logmsg { get; set; }
        public DateTime Regdate { get; set; }
        public string Regid { get; set; }
    }
}

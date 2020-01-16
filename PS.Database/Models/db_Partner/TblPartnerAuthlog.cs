using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerAuthlog
    {
        public int Logidx { get; set; }
        public string Empno { get; set; }
        public string Userid { get; set; }
        public byte Logtype { get; set; }
        public string Logmsg { get; set; }
        public string Adminid { get; set; }
        public DateTime Regdate { get; set; }
    }
}

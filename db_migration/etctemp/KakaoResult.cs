using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class KakaoResult
    {
        public int Finidx { get; set; }
        public int? EvtCode { get; set; }
        public int Inviteidx { get; set; }
        public string Uname { get; set; }
        public string Uphone { get; set; }
        public string Address { get; set; }
        public DateTime Regdate { get; set; }
        public string Okcode { get; set; }
        public string Prizecode { get; set; }
        public string Zipcode { get; set; }
        public string Prizeopt1 { get; set; }
        public string Prizeopt2 { get; set; }
    }
}

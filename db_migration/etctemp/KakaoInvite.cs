using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class KakaoInvite
    {
        public int Idx { get; set; }
        public int EvtCode { get; set; }
        public string UName { get; set; }
        public string UPhone { get; set; }
        public int? Ridx { get; set; }
        public DateTime Regdate { get; set; }
        public string Uip { get; set; }
        public int? Invitecnt { get; set; }
        public string Isusing { get; set; }
    }
}

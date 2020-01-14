using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblOnlineAppNotMatchReasonCode
    {
        public int Idx { get; set; }
        public string Pggubun { get; set; }
        public string Pguserid { get; set; }
        public string Pgkey { get; set; }
        public string Pgcskey { get; set; }
        public string Orderserial { get; set; }
        public string ReasonGubun { get; set; }
        public DateTime Regdate { get; set; }
    }
}

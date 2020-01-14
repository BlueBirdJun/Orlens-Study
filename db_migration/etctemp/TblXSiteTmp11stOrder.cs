using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteTmp11stOrder
    {
        public int Idx { get; set; }
        public string Outmallorderserial { get; set; }
        public string OrgDetailKey { get; set; }
        public string BeasongNum11st { get; set; }
        public string IsbaljuConfirmSend { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Mallid { get; set; }
    }
}

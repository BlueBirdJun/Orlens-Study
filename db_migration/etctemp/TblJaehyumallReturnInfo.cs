using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblJaehyumallReturnInfo
    {
        public string Mallgubun { get; set; }
        public string ReturnCode { get; set; }
        public string ReturnName { get; set; }
        public string ReturnAddress { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Isusing { get; set; }
        public string MapPid { get; set; }
    }
}

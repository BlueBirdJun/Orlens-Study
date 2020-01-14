using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblRejectMailTUniq
    {
        public string Email { get; set; }
        public int RjCnt { get; set; }
        public string Lastact { get; set; }
        public string FirstAct { get; set; }
        public string IisOrDb { get; set; }
    }
}

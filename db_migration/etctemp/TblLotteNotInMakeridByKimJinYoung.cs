using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblLotteNotInMakeridByKimJinYoung
    {
        public string Makerid { get; set; }
        public DateTime Regdate { get; set; }
        public string RegId { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string LastupdateId { get; set; }
        public string Isusing { get; set; }
    }
}

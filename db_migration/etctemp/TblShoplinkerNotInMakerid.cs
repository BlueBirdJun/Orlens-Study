using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblShoplinkerNotInMakerid
    {
        public int Idx { get; set; }
        public string Makerid { get; set; }
        public string Mallgubun { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Lastuserid { get; set; }
    }
}

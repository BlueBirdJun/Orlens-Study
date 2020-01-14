using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblShoplinkerNotInItemid
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string Mallgubun { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Lastuserid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEpShopNotInItemid
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string Mallgubun { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Regid { get; set; }
        public string Updateid { get; set; }
    }
}

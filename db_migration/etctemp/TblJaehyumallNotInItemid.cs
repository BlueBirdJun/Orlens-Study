using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblJaehyumallNotInItemid
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string Mallgubun { get; set; }
        public string Bigo { get; set; }
        public DateTime Regdate { get; set; }
    }
}

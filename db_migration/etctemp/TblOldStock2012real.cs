using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblOldStock2012real
    {
        public string Shopid { get; set; }
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public int Realstock { get; set; }
    }
}

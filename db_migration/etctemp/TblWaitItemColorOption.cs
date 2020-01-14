using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblWaitItemColorOption
    {
        public int Itemid { get; set; }
        public int ColorCode { get; set; }
        public string BasicImage { get; set; }
        public DateTime? Regdate { get; set; }
        public string Itemoption { get; set; }
    }
}

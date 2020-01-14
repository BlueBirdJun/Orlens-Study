using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblWemakeDealOption
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public int Quantity { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

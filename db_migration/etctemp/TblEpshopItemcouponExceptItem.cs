using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEpshopItemcouponExceptItem
    {
        public int Itemid { get; set; }
        public DateTime? Regdate { get; set; }
        public string Reguser { get; set; }
        public DateTime? AsignMaxDt { get; set; }
    }
}

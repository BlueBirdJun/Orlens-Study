using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEpShopRecentsellItem
    {
        public int Itemid { get; set; }
        public int SellNdays { get; set; }
        public int OrdNdays { get; set; }
        public int Sell1Days { get; set; }
        public int Ord1Days { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

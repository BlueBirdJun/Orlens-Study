using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemSaleInfo
    {
        public int Itemid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LastRegId { get; set; }
        public DateTime LastUpdate { get; set; }
        public string IsUsing { get; set; }
    }
}

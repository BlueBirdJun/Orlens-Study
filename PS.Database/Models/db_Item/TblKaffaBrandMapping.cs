using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblKaffaBrandMapping
    {
        public string TenMakerid { get; set; }
        public int KaffaMakerid { get; set; }
        public string IsUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

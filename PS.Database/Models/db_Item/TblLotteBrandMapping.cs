using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblLotteBrandMapping
    {
        public string TenMakerid { get; set; }
        public int LotteBrandCd { get; set; }
        public string LotteBrandName { get; set; }
        public string IsUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

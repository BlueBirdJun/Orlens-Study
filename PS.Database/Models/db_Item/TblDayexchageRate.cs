using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblDayexchageRate
    {
        public int Idx { get; set; }
        public string Yyyymmdd { get; set; }
        public decimal? Usd { get; set; }
        public decimal? Cny { get; set; }
        public decimal? Myr { get; set; }
        public DateTime Regdate { get; set; }
        public string RegUserid { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string LastUserid { get; set; }
        public decimal? Sgd { get; set; }
    }
}

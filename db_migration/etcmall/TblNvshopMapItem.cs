using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblNvshopMapItem
    {
        public int Itemid { get; set; }
        public string MatchNvMid { get; set; }
        public string Nvitemid { get; set; }
        public decimal Minprice { get; set; }
        public decimal Nvtensellcash { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEpShopMappingItem
    {
        public int Itemid { get; set; }
        public decimal Sellcash { get; set; }
        public int Myrank { get; set; }
        public int Mallmaxrank { get; set; }
        public int Malllowrank { get; set; }
        public decimal Lowcash { get; set; }
        public decimal Highcash { get; set; }
        public int SamecashCnt { get; set; }
        public DateTime Regdate { get; set; }
        public string MatchNvMid { get; set; }
        public decimal? Rank2price { get; set; }
        public decimal? Rank3price { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteCsDetail
    {
        public int Idx { get; set; }
        public int Masteridx { get; set; }
        public string OutMallItemId { get; set; }
        public string OutMallItemName { get; set; }
        public string OutMallItemOption { get; set; }
        public string OutMallItemOptionName { get; set; }
        public int ItemId { get; set; }
        public string Itemoption { get; set; }
        public decimal? SellPrice { get; set; }
        public decimal? RealSellPrice { get; set; }
        public string Vatinclude { get; set; }
        public int? ItemOrderCount { get; set; }
    }
}

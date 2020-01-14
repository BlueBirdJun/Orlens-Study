using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblShopifyCateMapping
    {
        public int? ShopifyCollectionId { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public int? Depth { get; set; }
        public int Id { get; set; }
    }
}

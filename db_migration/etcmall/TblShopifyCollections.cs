using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblShopifyCollections
    {
        public string Collectionid { get; set; }
        public int? Collectiontype { get; set; }
        public string Title { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Id { get; set; }
        public string LastErrStr { get; set; }
        public string Var1 { get; set; }
    }
}

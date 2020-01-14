using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallItemManager
    {
        public int Idx { get; set; }
        public string MallId { get; set; }
        public int ItemId { get; set; }
        public string MallItemName { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime? LastUpDate { get; set; }
    }
}

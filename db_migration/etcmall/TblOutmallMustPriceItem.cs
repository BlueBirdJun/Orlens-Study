using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallMustPriceItem
    {
        public int Idx { get; set; }
        public string Mallgubun { get; set; }
        public int Itemid { get; set; }
        public decimal MustPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string RegUserId { get; set; }
        public string LastUpdateUserId { get; set; }
    }
}

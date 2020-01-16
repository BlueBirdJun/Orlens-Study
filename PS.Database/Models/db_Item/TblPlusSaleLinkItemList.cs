using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblPlusSaleLinkItemList
    {
        public int PlusSaleItemId { get; set; }
        public int PlusSaleLinkItemId { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

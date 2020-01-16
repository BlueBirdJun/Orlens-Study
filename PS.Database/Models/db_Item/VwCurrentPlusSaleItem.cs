using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class VwCurrentPlusSaleItem
    {
        public int PlusSaleItemId { get; set; }
        public int PlusSaleLinkItemId { get; set; }
        public int PlusSalePro { get; set; }
        public double PlusSaleMargin { get; set; }
        public string PlusSaleMaginFlag { get; set; }
    }
}

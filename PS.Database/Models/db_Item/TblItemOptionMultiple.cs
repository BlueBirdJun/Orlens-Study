using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemOptionMultiple
    {
        public int Itemid { get; set; }
        public int TypeSeq { get; set; }
        public string KindSeq { get; set; }
        public string OptionTypeName { get; set; }
        public string OptionKindName { get; set; }
        public decimal Optaddprice { get; set; }
        public decimal Optaddbuyprice { get; set; }
    }
}

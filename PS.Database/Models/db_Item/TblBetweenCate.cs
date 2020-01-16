using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblBetweenCate
    {
        public long Catecode { get; set; }
        public short Depth { get; set; }
        public string Catename { get; set; }
        public string Useyn { get; set; }
        public short SortNo { get; set; }
    }
}

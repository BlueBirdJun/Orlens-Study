using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblDisplayCateWaitItem
    {
        public long Catecode { get; set; }
        public int Itemid { get; set; }
        public short Depth { get; set; }
        public int SortNo { get; set; }
        public string IsDefault { get; set; }
    }
}

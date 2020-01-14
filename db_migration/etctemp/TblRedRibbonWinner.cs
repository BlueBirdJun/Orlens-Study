using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblRedRibbonWinner
    {
        public string RedItemid { get; set; }
        public int RedSn { get; set; }
        public string WinUserid { get; set; }
        public DateTime? WinDate { get; set; }
        public int ItemSortNo { get; set; }
    }
}

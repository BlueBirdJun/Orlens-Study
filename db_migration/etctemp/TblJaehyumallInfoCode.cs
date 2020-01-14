using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblJaehyumallInfoCode
    {
        public string Mallgubun { get; set; }
        public string InfoCd { get; set; }
        public string InfoDiv { get; set; }
        public string InfoDivName { get; set; }
        public string InfoItemName { get; set; }
        public string InfoDesc { get; set; }
        public string IsUsing { get; set; }
        public int? SortNo { get; set; }
    }
}

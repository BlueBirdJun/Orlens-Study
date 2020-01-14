using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblRedRibbonItem
    {
        public int RedSn { get; set; }
        public string ItemName { get; set; }
        public string ItemContent { get; set; }
        public string ItemQuant { get; set; }
        public string BasicImage1 { get; set; }
        public string BasicImage2 { get; set; }
        public string BasicImage3 { get; set; }
        public string AddImage1 { get; set; }
        public string AddImage2 { get; set; }
        public string AddImage3 { get; set; }
        public string IsUsing { get; set; }
    }
}

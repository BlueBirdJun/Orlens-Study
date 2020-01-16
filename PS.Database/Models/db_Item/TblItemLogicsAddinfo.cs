using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemLogicsAddinfo
    {
        public int Itemid { get; set; }
        public string SubItemRackcode { get; set; }
        public string Lastcheckusersn { get; set; }
        public string ItemManageType { get; set; }
    }
}

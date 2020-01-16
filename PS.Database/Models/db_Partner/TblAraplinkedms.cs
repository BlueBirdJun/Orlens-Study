using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblAraplinkedms
    {
        public int AraplinkedmsIdx { get; set; }
        public decimal ArapCd { get; set; }
        public int EdmsIdx { get; set; }
        public bool? IsUsing { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerDispcate
    {
        public string Makerid { get; set; }
        public long Catecode { get; set; }
        public string Isdefault { get; set; }
        public int? ItemCnt { get; set; }
    }
}

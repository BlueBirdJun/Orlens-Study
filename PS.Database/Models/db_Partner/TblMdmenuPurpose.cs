using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblMdmenuPurpose
    {
        public int Idx { get; set; }
        public long Catecode { get; set; }
        public string Yyyy { get; set; }
        public string Mm { get; set; }
        public string Gubun { get; set; }
        public decimal? TargetMoney { get; set; }
        public decimal? ProfitMoney { get; set; }
    }
}

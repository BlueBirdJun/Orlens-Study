using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblMonthlySoldoutCancel
    {
        public string Yyyymm { get; set; }
        public string Gubun { get; set; }
        public string CommName { get; set; }
        public string AllianceYn { get; set; }
        public int Totalcnt { get; set; }
    }
}

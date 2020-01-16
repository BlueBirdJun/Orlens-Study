using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TmpWorkTableByMonth
    {
        public string Empno { get; set; }
        public string Yyyymm { get; set; }
        public double? MonVacationDay { get; set; }
        public double? TotVacationDay { get; set; }
        public double? YearVacationDay { get; set; }
    }
}

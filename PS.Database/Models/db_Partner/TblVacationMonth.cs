using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblVacationMonth
    {
        public string Empno { get; set; }
        public string Yyyymm { get; set; }
        public double MonVacationDay { get; set; }
        public double YearVacationDay { get; set; }
        public DateTime Regdate { get; set; }
        public string Adminid { get; set; }
        public int? PositSn { get; set; }
    }
}

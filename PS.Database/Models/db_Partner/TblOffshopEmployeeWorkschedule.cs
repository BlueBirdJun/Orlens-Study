using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOffshopEmployeeWorkschedule
    {
        public string Empno { get; set; }
        public DateTime Workdate { get; set; }
        public int PartSn { get; set; }
        public string Workcode { get; set; }
        public string Reguserid { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerAddDepartment
    {
        public int Depidx { get; set; }
        public string Empno { get; set; }
        public string Userid { get; set; }
        public int Departmentid { get; set; }
        public bool? Isusing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

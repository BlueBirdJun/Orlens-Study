using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserDepartment
    {
        public int Cid { get; set; }
        public int Pid { get; set; }
        public string DepartmentName { get; set; }
        public int? DispOrderNo { get; set; }
        public string UseYn { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

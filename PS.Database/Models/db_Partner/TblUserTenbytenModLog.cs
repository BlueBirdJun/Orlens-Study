using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserTenbytenModLog
    {
        public int Logidx { get; set; }
        public string Empno { get; set; }
        public int PositSn { get; set; }
        public string PositName { get; set; }
        public int JobSn { get; set; }
        public string JobName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentFullName { get; set; }
        public string Changedate { get; set; }
        public DateTime Regdate { get; set; }
        public string Adminid { get; set; }
        public bool? IsUsing { get; set; }
        public string ChangePn { get; set; }
        public string ChangePndate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserLoginIp
    {
        public int Idx { get; set; }
        public string Ipaddress { get; set; }
        public int DepartmentId { get; set; }
        public string Userid { get; set; }
        public string Managername { get; set; }
        public string Comment { get; set; }
        public string Usescmyn { get; set; }
        public string Uselogicsyn { get; set; }
        public string Usecustomerinfoyn { get; set; }
        public string Reguserid { get; set; }
        public string Modiuserid { get; set; }
        public string Useyn { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

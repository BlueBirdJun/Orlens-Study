using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblTenAgitPoint
    {
        public int Pidx { get; set; }
        public string Empno { get; set; }
        public string Userid { get; set; }
        public int TotPoint { get; set; }
        public int UsePoint { get; set; }
        public string Yyyy { get; set; }
        public string Startday { get; set; }
        public string Endday { get; set; }
        public string Adminid { get; set; }
        public DateTime Regdate { get; set; }
        public bool? Isusing { get; set; }
    }
}

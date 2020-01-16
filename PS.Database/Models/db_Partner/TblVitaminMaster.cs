using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblVitaminMaster
    {
        public int Midx { get; set; }
        public string Empno { get; set; }
        public string Userid { get; set; }
        public string Yyyy { get; set; }
        public DateTime? Startday { get; set; }
        public DateTime? Endday { get; set; }
        public decimal Totvm { get; set; }
        public decimal Usevm { get; set; }
        public string Adminid { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public bool? Isusing { get; set; }
    }
}

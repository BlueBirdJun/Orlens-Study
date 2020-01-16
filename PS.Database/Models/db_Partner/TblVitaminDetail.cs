using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblVitaminDetail
    {
        public int Didx { get; set; }
        public int Midx { get; set; }
        public decimal Vmmoney { get; set; }
        public byte Vmstatus { get; set; }
        public string Adminid { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public bool? Isusing { get; set; }
        public DateTime? Paydate { get; set; }
    }
}

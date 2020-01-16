using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblTenAgitPenalty
    {
        public int Pidx { get; set; }
        public int Idx { get; set; }
        public byte Penaltykind { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public DateTime? Regdate { get; set; }
        public string Adminid { get; set; }
        public string Empno { get; set; }
        public string PenaltyCause { get; set; }
        public int? PenaltyPoint { get; set; }
    }
}

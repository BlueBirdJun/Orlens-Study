using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerSignlist
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public string Gubunid { get; set; }
        public string Statecd { get; set; }
        public DateTime? Signdate { get; set; }
        public string Isexpired { get; set; }
        public DateTime? Regdate { get; set; }
        public string Maeipgubun { get; set; }
        public double? Defaultmargin { get; set; }
        public string Jungsandate { get; set; }
        public string Document { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerAddJungsanInfo
    {
        public string Partnerid { get; set; }
        public string JungsanBank { get; set; }
        public string JungsanAcctno { get; set; }
        public string JungsanAcctname { get; set; }
        public string JungsanDate { get; set; }
        public string JungsanDateOff { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

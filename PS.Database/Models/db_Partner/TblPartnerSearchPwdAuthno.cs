using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerSearchPwdAuthno
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public string Refip { get; set; }
        public DateTime Regdate { get; set; }
        public string Authno { get; set; }
        public string IsSucess { get; set; }
    }
}

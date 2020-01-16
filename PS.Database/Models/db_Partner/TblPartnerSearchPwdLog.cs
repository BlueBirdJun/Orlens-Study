using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerSearchPwdLog
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public string Refip { get; set; }
        public DateTime Regdate { get; set; }
    }
}

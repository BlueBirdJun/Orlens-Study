using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserAutoLoginCpnEvalTarget
    {
        public int Logidx { get; set; }
        public string Userid { get; set; }
        public DateTime Regdate { get; set; }
    }
}

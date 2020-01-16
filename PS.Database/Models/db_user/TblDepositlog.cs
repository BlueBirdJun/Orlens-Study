using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblDepositlog
    {
        public decimal Idx { get; set; }
        public string Userid { get; set; }
        public int Deposit { get; set; }
        public int Jukyocd { get; set; }
        public string Jukyo { get; set; }
        public string Orderserial { get; set; }
        public string Deleteyn { get; set; }
        public string Reguserid { get; set; }
        public string Deluserid { get; set; }
        public DateTime Regdate { get; set; }
        public string Fixyyyymmdd { get; set; }
        public int? Asid { get; set; }
    }
}

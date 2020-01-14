using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEventEtcYongman
    {
        public int Idx { get; set; }
        public int EventCode { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Usermail { get; set; }
        public string Emailok { get; set; }
        public string Email10x10 { get; set; }
        public string Usercell { get; set; }
        public string Smsok { get; set; }
        public int? Itemid { get; set; }
        public int? Couponidx { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
        public string Winnerdate { get; set; }
        public string Bigo { get; set; }
    }
}

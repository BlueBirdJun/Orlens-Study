using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblMailzineNotmember
    {
        public int Idx { get; set; }
        public string Username { get; set; }
        public string Usermail { get; set; }
        public DateTime Regdate { get; set; }
        public string Isusing { get; set; }
        public string Email10x10 { get; set; }
        public string EmailFingers { get; set; }
    }
}

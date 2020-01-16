using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserSns
    {
        public string Snsgubun { get; set; }
        public string Tenbytenid { get; set; }
        public string Snsid { get; set; }
        public string Usermail { get; set; }
        public string Nickname { get; set; }
        public string Age { get; set; }
        public string Sexflag { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblInvalidUser
    {
        public int Idx { get; set; }
        public string Gubun { get; set; }
        public string Invaliduserid { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Reguserid { get; set; }
        public string Lastuserid { get; set; }
        public string Comment { get; set; }
    }
}

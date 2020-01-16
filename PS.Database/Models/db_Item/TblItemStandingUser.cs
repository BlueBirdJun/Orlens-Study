using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemStandingUser
    {
        public int Uidx { get; set; }
        public int Orgitemid { get; set; }
        public string Orgitemoption { get; set; }
        public int Reserveidx { get; set; }
        public string Jukyogubun { get; set; }
        public string Orderserial { get; set; }
        public string Userid { get; set; }
        public int? Itemno { get; set; }
        public int Sendstatus { get; set; }
        public DateTime? Senddate { get; set; }
        public string Username { get; set; }
        public string Zipcode { get; set; }
        public string Reqzipaddr { get; set; }
        public string Useraddr { get; set; }
        public string Userphone { get; set; }
        public string Usercell { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
        public string Regadminid { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Lastadminid { get; set; }
        public int? Rebeasongbeforeuidx { get; set; }
        public int? Sudongmachinguidx { get; set; }
        public int? SendkeyX { get; set; }
    }
}

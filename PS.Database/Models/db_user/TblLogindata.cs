using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblLogindata
    {
        public string Userid { get; set; }
        public string Userpass { get; set; }
        public string Userdiv { get; set; }
        public string UserpwQ { get; set; }
        public string UserpwA { get; set; }
        public DateTime? Lastlogin { get; set; }
        public int? Counter { get; set; }
        public int? Userlevel { get; set; }
        public string Touchusing { get; set; }
        public DateTime? Touchrenewdate { get; set; }
        public string Lastrefip { get; set; }
        public string EncUserpass { get; set; }
        public string EncUserpass64 { get; set; }
        public int Useq { get; set; }
    }
}

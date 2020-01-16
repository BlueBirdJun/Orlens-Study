using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblDeluser
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Useremail { get; set; }
        public string Juminno { get; set; }
        public DateTime Regdate { get; set; }
        public string Complaindiv { get; set; }
        public string Complaintext { get; set; }
        public string ChkMethod { get; set; }
        public string Zipcode { get; set; }
        public string Device { get; set; }
        public DateTime? Joindate { get; set; }
        public short? Age { get; set; }
        public string Gender { get; set; }
        public string Area { get; set; }
        public int? Useq { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblInvalidEmail
    {
        public string InvalidEmail { get; set; }
        public string Fixgubun { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserSnsToken
    {
        public string Snsid { get; set; }
        public string Snsgubun { get; set; }
        public string Snstoken { get; set; }
    }
}

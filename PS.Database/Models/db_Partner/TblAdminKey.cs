using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblAdminKey
    {
        public int Idx { get; set; }
        public string KeyIdx { get; set; }
        public string Teamname { get; set; }
        public string Username { get; set; }
        public string UsernameDetail { get; set; }
        public string DelIsusing { get; set; }
    }
}

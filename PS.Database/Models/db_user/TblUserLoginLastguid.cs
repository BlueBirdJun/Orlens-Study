using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserLoginLastguid
    {
        public string Userid { get; set; }
        public string Lastguid { get; set; }
        public DateTime Regdt { get; set; }
        public DateTime Lastupdt { get; set; }
    }
}

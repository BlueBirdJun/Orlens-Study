using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserAllowSite
    {
        public string Userid { get; set; }
        public string Sitegubun { get; set; }
        public string Siteusing { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Allowdate { get; set; }
        public DateTime? Disallowdate { get; set; }
    }
}

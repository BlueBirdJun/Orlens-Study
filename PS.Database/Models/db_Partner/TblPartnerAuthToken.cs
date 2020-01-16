using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerAuthToken
    {
        public string Groupid { get; set; }
        public string Token { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string RegUserId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Refip { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblTenAgitSmsInfo
    {
        public byte AreaDiv { get; set; }
        public string Contents { get; set; }
        public DateTime Regdate { get; set; }
        public string Adminid { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}

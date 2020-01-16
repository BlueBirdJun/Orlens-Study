using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppCommCd
    {
        public int CommCd { get; set; }
        public int? Parentkey { get; set; }
        public string CommName { get; set; }
        public string CommDesc { get; set; }
        public string ErpCode { get; set; }
        public int Dispnum { get; set; }
        public bool? ActiveYn { get; set; }
    }
}

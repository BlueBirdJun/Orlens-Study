using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class VwUserMailListHalfBefore
    {
        public long? Rownum { get; set; }
        public string Umail { get; set; }
        public string Uname { get; set; }
        public string Mailok { get; set; }
        public string Fingersmailok { get; set; }
    }
}

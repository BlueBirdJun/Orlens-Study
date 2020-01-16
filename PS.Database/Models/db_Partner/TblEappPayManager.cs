using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEappPayManager
    {
        public int PayManagerIdx { get; set; }
        public string Userid { get; set; }
        public byte PayManagerType { get; set; }
        public bool? IsUsing { get; set; }
        public bool? IsDef { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppAccount
    {
        public int AccountIdx { get; set; }
        public int AccountKind { get; set; }
        public int? EdmsIdx { get; set; }
        public string AccountName { get; set; }
        public bool? IsUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

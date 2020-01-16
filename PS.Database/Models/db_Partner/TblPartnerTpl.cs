using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerTpl
    {
        public string Tplcompanyid { get; set; }
        public string Tplcompanyname { get; set; }
        public string Groupid { get; set; }
        public string BillUseYn { get; set; }
        public string BillUserId { get; set; }
        public string BillUserPass { get; set; }
        public string UseYn { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

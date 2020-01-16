using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOpExpAccount
    {
        public int OpExpAccountidx { get; set; }
        public decimal? ArapCd { get; set; }
        public int? CommCd { get; set; }
        public bool? Inouttype { get; set; }
        public DateTime Regdate { get; set; }
        public bool? IsUsing { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblBreakdownRequest
    {
        public TblBreakdownRequest()
        {
            TblBreakdownRequestDetail = new HashSet<TblBreakdownRequestDetail>();
        }

        public int Idx { get; set; }
        public string ReqUserid { get; set; }
        public int ReqPartSn { get; set; }
        public DateTime ReqRegdate { get; set; }

        public virtual ICollection<TblBreakdownRequestDetail> TblBreakdownRequestDetail { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblLtiMallCsnoti
    {
        public string OrderNo { get; set; }
        public string OrderSeq { get; set; }
        public string Mallid { get; set; }
        public DateTime? OrderDt { get; set; }
        public int? CnclCnt { get; set; }
        public decimal? CnclAmt { get; set; }
        public string OrderStts { get; set; }
        public DateTime? CnclDt { get; set; }
        public string Refip { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

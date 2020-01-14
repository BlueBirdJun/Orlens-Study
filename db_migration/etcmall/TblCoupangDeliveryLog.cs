using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblCoupangDeliveryLog
    {
        public int Idx { get; set; }
        public string Makerid { get; set; }
        public string LastErrMsg { get; set; }
        public string ResultCode { get; set; }
        public DateTime Regdate { get; set; }
        public int? FailCnt { get; set; }
    }
}

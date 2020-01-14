using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallOptionApiQue
    {
        public long Idx { get; set; }
        public string Mallid { get; set; }
        public string ApiAction { get; set; }
        public int Midx { get; set; }
        public int Priority { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Readdate { get; set; }
        public DateTime? Findate { get; set; }
        public string ResultCode { get; set; }
        public string LastErrMsg { get; set; }
        public string LastUserid { get; set; }
    }
}

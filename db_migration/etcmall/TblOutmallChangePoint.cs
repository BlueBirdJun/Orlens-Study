using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallChangePoint
    {
        public int Idx { get; set; }
        public string Changelogidx { get; set; }
        public int? Itemid { get; set; }
        public string Gubun { get; set; }
        public string Processingyn { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Processingdate { get; set; }
        public string Message { get; set; }
    }
}

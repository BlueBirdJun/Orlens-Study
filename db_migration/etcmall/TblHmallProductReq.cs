using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHmallProductReq
    {
        public int Idx { get; set; }
        public string InfNotfBsicCd { get; set; }
        public string ItstCd { get; set; }
        public string SortOrdg { get; set; }
        public string ItstTitl { get; set; }
        public string MinInsrByteLen { get; set; }
        public string InfNotfBsicTitl { get; set; }
        public string BlcwdIdxYn { get; set; }
        public string Catekey { get; set; }
    }
}

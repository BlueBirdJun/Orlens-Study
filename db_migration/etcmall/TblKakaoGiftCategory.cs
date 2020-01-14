using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblKakaoGiftCategory
    {
        public string DepthCode { get; set; }
        public string Depth1Nm { get; set; }
        public string Depth2Nm { get; set; }
        public string Depth3Nm { get; set; }
        public string Depth4Nm { get; set; }
        public int? BrandCode { get; set; }
        public int? NeedInfoDiv { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblKakaoGiftCateMapping
    {
        public string DepthCode { get; set; }
        public string TenCateLarge { get; set; }
        public string TenCateMid { get; set; }
        public string TenCateSmall { get; set; }
        public int? BrandCode { get; set; }
        public DateTime? Lastupdate { get; set; }
        public int? NeedInfoDiv { get; set; }
    }
}

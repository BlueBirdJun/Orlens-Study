using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblNvstorefarmImage
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string ImgType { get; set; }
        public string TenUrl { get; set; }
        public string StorefarmUrl { get; set; }
    }
}

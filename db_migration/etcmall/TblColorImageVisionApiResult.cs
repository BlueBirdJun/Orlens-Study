using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblColorImageVisionApiResult
    {
        public int ImgQueIdx { get; set; }
        public int ColorRank { get; set; }
        public int Itemid { get; set; }
        public string Basicimagename { get; set; }
        public string ColorName { get; set; }
        public double ColorScore { get; set; }
        public DateTime Regdate { get; set; }
    }
}

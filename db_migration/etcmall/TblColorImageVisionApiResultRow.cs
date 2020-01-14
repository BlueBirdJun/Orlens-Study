using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblColorImageVisionApiResultRow
    {
        public int ImgQueIdx { get; set; }
        public int Rowidx { get; set; }
        public int Itemid { get; set; }
        public string Basicimagename { get; set; }
        public double ColorScore { get; set; }
        public double PixelFraction { get; set; }
        public string ColorRgb { get; set; }
    }
}

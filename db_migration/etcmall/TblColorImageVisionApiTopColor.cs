using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblColorImageVisionApiTopColor
    {
        public int Itemid { get; set; }
        public string Basicimagename { get; set; }
        public string ColorName { get; set; }
        public double ColorScore { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public int LastImgQueIdx { get; set; }
    }
}

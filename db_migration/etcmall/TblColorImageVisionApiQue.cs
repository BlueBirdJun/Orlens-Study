using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblColorImageVisionApiQue
    {
        public int ImgQueIdx { get; set; }
        public int Itemid { get; set; }
        public string Basicimagename { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Readdate { get; set; }
        public DateTime? Findate { get; set; }
        public string Resultcd { get; set; }
    }
}

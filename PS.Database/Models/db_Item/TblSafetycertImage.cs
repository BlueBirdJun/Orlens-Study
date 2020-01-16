using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblSafetycertImage
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string CertNum { get; set; }
        public string ImageUrls { get; set; }
    }
}

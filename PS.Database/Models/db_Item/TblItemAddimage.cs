using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemAddimage
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public int Imgtype { get; set; }
        public int Gubun { get; set; }
        public string Addimage400 { get; set; }
        public string Addimage600 { get; set; }
        public string Addimage1000 { get; set; }
    }
}

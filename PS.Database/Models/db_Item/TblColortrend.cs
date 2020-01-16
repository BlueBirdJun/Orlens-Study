using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblColortrend
    {
        public int Ctcode { get; set; }
        public int Colorcode { get; set; }
        public string Isusing { get; set; }
        public int State { get; set; }
        public string Mainimage { get; set; }
        public string Mainimagelink { get; set; }
        public string Textimage { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime Regdate { get; set; }
        public string Lastadminid { get; set; }
        public int? Viewno { get; set; }
        public string Partwdid { get; set; }
        public string Partmdid { get; set; }
        public string Listimg { get; set; }
        public string Nmainimg { get; set; }
        public string Colortitle { get; set; }
        public string Mainimagelinknew { get; set; }
    }
}

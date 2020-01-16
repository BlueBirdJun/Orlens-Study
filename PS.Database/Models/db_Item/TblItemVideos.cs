using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemVideos
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string Videogubun { get; set; }
        public string Videotype { get; set; }
        public string Videourl { get; set; }
        public int? Videowidth { get; set; }
        public int? Videoheight { get; set; }
        public string Videofullurl { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Modifydate { get; set; }
    }
}

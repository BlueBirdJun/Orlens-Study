using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemMultiSiteRegItem
    {
        public int Itemid { get; set; }
        public string Sitename { get; set; }
        public string Isusing { get; set; }
        public int SiteScore { get; set; }
        public int Multilangcnt { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Lastuserid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemContents
    {
        public int Itemid { get; set; }
        public string Keywords { get; set; }
        public string Sourcearea { get; set; }
        public string Makername { get; set; }
        public string Itemsource { get; set; }
        public string Itemsize { get; set; }
        public string Usinghtml { get; set; }
        public string Itemcontent { get; set; }
        public string Ordercomment { get; set; }
        public string Designercomment { get; set; }
        public int Sellcount { get; set; }
        public int Favcount { get; set; }
        public int Recentsellcount { get; set; }
        public int Recentfavcount { get; set; }
        public int Recentpoints { get; set; }
        public int Recentpcount { get; set; }
        public int Qnacnt { get; set; }
        public int AvgDlvDate { get; set; }
        public int RequireMakeDay { get; set; }
        public string SafetyYn { get; set; }
        public byte? SafetyDiv { get; set; }
        public string SafetyNum { get; set; }
        public string InfoDiv { get; set; }
        public decimal? FreightMin { get; set; }
        public decimal? FreightMax { get; set; }
        public byte? Sourcekind { get; set; }
        public string Addmsg { get; set; }
        public string Addcarve { get; set; }
        public string Addbox { get; set; }
        public string Addset { get; set; }
        public string Addcustom { get; set; }
        public string Isbn13 { get; set; }
        public string IsbnSub { get; set; }
        public string Isbn10 { get; set; }
    }
}

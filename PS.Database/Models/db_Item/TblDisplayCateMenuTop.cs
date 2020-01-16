using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblDisplayCateMenuTop
    {
        public int Idx { get; set; }
        public long Disp1 { get; set; }
        public string Type { get; set; }
        public string Subject { get; set; }
        public string Linkurl { get; set; }
        public int Itemid { get; set; }
        public string Imgurl { get; set; }
        public int Sortno { get; set; }
        public string Sdate { get; set; }
        public string Edate { get; set; }
        public string Useyn { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public string Ordertext { get; set; }
    }
}

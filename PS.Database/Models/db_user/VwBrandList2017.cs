using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class VwBrandList2017
    {
        public string Userid { get; set; }
        public string KorDiv { get; set; }
        public string EngDiv { get; set; }
        public string Socname { get; set; }
        public string SocnameKor { get; set; }
        public int? Recommendcount { get; set; }
        public int? Todayrecommendcount { get; set; }
        public string Hitflg { get; set; }
        public string Saleflg { get; set; }
        public string Smileflg { get; set; }
        public string Newflg { get; set; }
        public string Giftflg { get; set; }
        public string Onlyflg { get; set; }
        public string Artistflg { get; set; }
        public string Kdesignflg { get; set; }
        public long? SortKor { get; set; }
        public long? SortEng { get; set; }
        public int? Sellrank { get; set; }
    }
}

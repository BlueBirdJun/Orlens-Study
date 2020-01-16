using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerMenu
    {
        public int Id { get; set; }
        public string Menuname { get; set; }
        public string Linkurl { get; set; }
        public string Haschild { get; set; }
        public int Viewidx { get; set; }
        public int Parentid { get; set; }
        public int Divcd { get; set; }
        public string Isusing { get; set; }
        public string Menucolor { get; set; }
        public string Menuposnotice { get; set; }
        public string Menuposhelp { get; set; }
        public string MenunameEn { get; set; }
        public string UseSslYn { get; set; }
        public int? Criticinfo { get; set; }
        public int? SaveLog { get; set; }
    }
}

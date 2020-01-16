using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblXSiteBrandInfo
    {
        public int Idx { get; set; }
        public string XSiteId { get; set; }
        public string Makerid { get; set; }
        public string Gubun { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Comment { get; set; }
        public string Useyn { get; set; }
        public DateTime? Regdate { get; set; }
        public string Reguserid { get; set; }
    }
}

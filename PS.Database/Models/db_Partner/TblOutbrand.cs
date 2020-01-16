using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOutbrand
    {
        public string Yyyymm { get; set; }
        public string Makerid { get; set; }
        public string Makername { get; set; }
        public int? Makerlevel { get; set; }
        public int? Newitemcount { get; set; }
        public decimal? Lastonjungsansum { get; set; }
        public decimal? Lastoffjungsansum { get; set; }
        public int? Lastminuscnt { get; set; }
        public decimal? Lastminussum { get; set; }
        public int? Usingitemcount { get; set; }
        public DateTime? Regdate { get; set; }
        public string LastsellDateOn { get; set; }
        public string LastsellDateOf { get; set; }
        public string Lastgrouplogindate { get; set; }
        public string LastPartnerLogindate { get; set; }
    }
}

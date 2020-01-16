using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOpExpMonthlyCard
    {
        public int OpExpCardIdx { get; set; }
        public string Yyyymm { get; set; }
        public int? OpExpPartIdx { get; set; }
        public decimal? OutExp { get; set; }
        public byte State { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Regid { get; set; }
        public string ErpLinkType { get; set; }
        public string ErpLinkKey { get; set; }
    }
}

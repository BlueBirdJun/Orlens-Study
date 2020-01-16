using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOpExpMonthly
    {
        public int OpExpidx { get; set; }
        public string Yyyymm { get; set; }
        public int OpExpPartidx { get; set; }
        public decimal LastMonthExp { get; set; }
        public decimal InExp { get; set; }
        public decimal OutExp { get; set; }
        public decimal TotExp { get; set; }
        public byte State { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string RegId { get; set; }
        public string ErpLinkType { get; set; }
        public string ErpLinkKey { get; set; }
    }
}

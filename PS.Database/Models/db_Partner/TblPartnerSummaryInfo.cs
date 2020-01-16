using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerSummaryInfo
    {
        public string Makerid { get; set; }
        public string SmKeyName { get; set; }
        public string SmKeyValVar { get; set; }
        public int? SmKeyValInt { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}

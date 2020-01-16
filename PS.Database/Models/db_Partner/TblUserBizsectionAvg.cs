using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserBizsectionAvg
    {
        public int AvgIdx { get; set; }
        public string Yyyymm { get; set; }
        public string UserBizCd { get; set; }
        public string SupBizCd { get; set; }
        public double AvgPersent { get; set; }
        public DateTime Regdate { get; set; }
    }
}

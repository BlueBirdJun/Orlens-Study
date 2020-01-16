using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblTmsSlAccCdGrp
    {
        public string AccGrpCd { get; set; }
        public string AccFcls { get; set; }
        public string AccGrpNm { get; set; }
        public string BeginCd { get; set; }
        public string EndCd { get; set; }
        public decimal? DispSeq { get; set; }
        public string UseYn { get; set; }
        public string DelYn { get; set; }
        public DateTime? BitchkDt { get; set; }
        public string AccountSection { get; set; }
    }
}

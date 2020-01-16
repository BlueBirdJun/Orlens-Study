using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblBizMonthProfitBizsection
    {
        public int BizProfitIdx { get; set; }
        public string Yyyymm { get; set; }
        public string BizsectionCd { get; set; }
        public string BizsectionNm { get; set; }
        public string AccGrpCd { get; set; }
        public string AccGrpNm { get; set; }
        public string AccCdUp { get; set; }
        public string AccUpNm { get; set; }
        public string AccCd { get; set; }
        public string AccUseCd { get; set; }
        public string AccNm { get; set; }
        public decimal? DebitSum { get; set; }
        public decimal? CreditSum { get; set; }
        public byte? BizType { get; set; }
        public bool? IsSupport { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

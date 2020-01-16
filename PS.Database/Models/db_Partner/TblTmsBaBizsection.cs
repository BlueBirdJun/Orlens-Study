using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblTmsBaBizsection
    {
        public string BizsectionCd { get; set; }
        public string UseYn { get; set; }
        public string BizsectionNm { get; set; }
        public string BizsectionCdUp { get; set; }
        public string GrpYn { get; set; }
        public string Gbcd1 { get; set; }
        public string Gbcd2 { get; set; }
        public string Gbcd3 { get; set; }
        public string Gbcd4 { get; set; }
        public decimal? DispSeq { get; set; }
        public string ModUser { get; set; }
        public string ModDt { get; set; }
        public string Bigo { get; set; }
        public string DelYn { get; set; }
        public DateTime? BitchkDt { get; set; }
        public string ErpCd { get; set; }
        public bool? IsView { get; set; }
        public bool? IsSales { get; set; }
        public string BizsectionUseCd { get; set; }
        public string RegUser { get; set; }
        public DateTime? RegDatetime { get; set; }
        public string BizNo { get; set; }
    }
}

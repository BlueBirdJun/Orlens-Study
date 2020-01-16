using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblTmsBaProd
    {
        public string ProdCd { get; set; }
        public string UseYn { get; set; }
        public string ProdNm { get; set; }
        public string ArapGb { get; set; }
        public string GrpYn { get; set; }
        public string ProdCdUp { get; set; }
        public string AccCd { get; set; }
        public string AccCdRmkSeq { get; set; }
        public string ErpCd { get; set; }
        public decimal? DispSeq { get; set; }
        public string Gbcd1 { get; set; }
        public string Gbcd2 { get; set; }
        public string Gbcd3 { get; set; }
        public string Gbcd4 { get; set; }
        public string ModUser { get; set; }
        public string ModDt { get; set; }
        public string Bigo { get; set; }
        public string DelYn { get; set; }
        public DateTime? BitchkDt { get; set; }
        public decimal? ArapCd { get; set; }
        public decimal? ArapSeq { get; set; }
        public string VsAccCd { get; set; }
        public string ProdType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblSsgMmgCategory
    {
        public string SiteNo { get; set; }
        public string SiteNm { get; set; }
        public string BuyFrmCd { get; set; }
        public string StdCtgGrpCd { get; set; }
        public string StdCtgGrpNm { get; set; }
        public string StdCtgLclsId { get; set; }
        public string StdCtgLclsNm { get; set; }
        public string StdCtgMclsId { get; set; }
        public string StdCtgMclsNm { get; set; }
        public string StdCtgSclsId { get; set; }
        public string StdCtgSclsNm { get; set; }
        public string StdCtgDclsId { get; set; }
        public string StdCtgDclsNm { get; set; }
        public string ItemMngPropClsId { get; set; }
        public string ItemMngPropClsNm { get; set; }
        public string ChldCertTgtYn { get; set; }
        public string SafeCertTgtYn { get; set; }
        public string ElecCertTgtYn { get; set; }
        public string HarmCertTgtYn { get; set; }
        public string TxnPermitDivCd { get; set; }
        public string TxnPermitDivNm { get; set; }
    }
}

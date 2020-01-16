using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEseroTax
    {
        public string TaxKey { get; set; }
        public string AppDate { get; set; }
        public string SellCorpNo { get; set; }
        public string SellJongNo { get; set; }
        public string SellCorpName { get; set; }
        public string SellCeoName { get; set; }
        public string SellEmail { get; set; }
        public string BuyCorpNo { get; set; }
        public string BuyJongNo { get; set; }
        public string BuyCorpName { get; set; }
        public string BuyCeoName { get; set; }
        public string BuyEmail { get; set; }
        public decimal TotSum { get; set; }
        public decimal SuplySum { get; set; }
        public decimal TaxSum { get; set; }
        public int TaxSellType { get; set; }
        public int TaxModiType { get; set; }
        public int TaxType { get; set; }
        public string EvalTypeNm { get; set; }
        public string Bigo { get; set; }
        public string RecreqGubunNm { get; set; }
        public string DtlDate { get; set; }
        public string DtlName { get; set; }
        public decimal DtlSuplysum { get; set; }
        public decimal DtltaxSum { get; set; }
        public string DtlBigo { get; set; }
        public string ReqDate { get; set; }
        public string SendDate { get; set; }
        public DateTime? Regdate { get; set; }
        public string TaxCustCd { get; set; }
        public decimal? TaxArapCd { get; set; }
        public string DtlNameOrg { get; set; }
        public int? MayErrType { get; set; }
    }
}

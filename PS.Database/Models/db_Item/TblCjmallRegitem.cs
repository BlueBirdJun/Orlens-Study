using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblCjmallRegitem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? CjmallRegdate { get; set; }
        public DateTime? CjmallLastUpdate { get; set; }
        public string CjmallPrdNo { get; set; }
        public decimal CjmallPrice { get; set; }
        public string CjmallSellYn { get; set; }
        public int CjmallStatCd { get; set; }
        public int? RegedOptCnt { get; set; }
        public int? RctSellCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public string Infodiv { get; set; }
        public string Cdmkey { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public DateTime? LastPriceCheckDate { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
        public string Regitemname { get; set; }
    }
}

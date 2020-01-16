using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblInterparkRegItem
    {
        public int Itemid { get; set; }
        public DateTime? Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? Interparkregdate { get; set; }
        public DateTime? Interparklastupdate { get; set; }
        public string InterParkPrdNo { get; set; }
        public int? InterParkSupplyCtrtSeq { get; set; }
        public string InterParkStoreCategory { get; set; }
        public string PinterParkDispCategory { get; set; }
        public decimal? MayiParkPrice { get; set; }
        public string MayiParkSellYn { get; set; }
        public int? RctSellCnt { get; set; }
        public int? RegedOptCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public string Regcatecode { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
        public string RegimageName { get; set; }
        public int? EditQueCnt { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblKaffaRegItem
    {
        public int Itemid { get; set; }
        public DateTime? Regdate { get; set; }
        public int? Kaffamakerid { get; set; }
        public string Reguserid { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Useyn { get; set; }
        public int? KaffaGoodNo { get; set; }
        public decimal? KaffaPrice { get; set; }
        public string KaffaSellyn { get; set; }
        public int? KaffaIsDisplay { get; set; }
        public int? KaffaIsDeleted { get; set; }
        public decimal? KaffaSuplyPrice { get; set; }
        public decimal? KaffaConsumerPrice { get; set; }
        public decimal? KaffaDiscountPrice { get; set; }
        public double? KaffaDiscountRate { get; set; }
        public DateTime? KaffaDiscountBeginDateTime { get; set; }
        public DateTime? KaffaDiscountEndDateTime { get; set; }
        public int? KaffaMinimum { get; set; }
        public int? KaffaMaxium { get; set; }
        public DateTime? KaffaRegDateTime { get; set; }
        public int? KaffaWeight { get; set; }
        public int? KaffaIsShippingfree { get; set; }
        public int? RctSellCnt { get; set; }
        public int? RegedoptCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
    }
}

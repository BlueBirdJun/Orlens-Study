using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblNvstorefarmclassRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? NvClassRegdate { get; set; }
        public DateTime? NvClassLastUpdate { get; set; }
        public string NvClassGoodNo { get; set; }
        public decimal NvClassPrice { get; set; }
        public string NvClassSellYn { get; set; }
        public int NvClassStatCd { get; set; }
        public DateTime? LastConfirmdate { get; set; }
        public int? RctSellCnt { get; set; }
        public int? RegedOptCnt { get; set; }
        public int? AccFailCnt { get; set; }
        public string LastErrStr { get; set; }
        public DateTime? LastStatCheckDate { get; set; }
        public string Regitemname { get; set; }
        public int? OptAddPrcCnt { get; set; }
        public int? OptAddPrcRegType { get; set; }
        public string RegImageName { get; set; }
        public int? EditQuecnt { get; set; }
        public string ApiaddImg { get; set; }
    }
}

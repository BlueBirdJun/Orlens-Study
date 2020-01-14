using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblGmarket1010RegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? GmarketRegdate { get; set; }
        public DateTime? GmarketLastUpdate { get; set; }
        public string GmarketGoodNo { get; set; }
        public string G9goodNo { get; set; }
        public decimal GmarketPrice { get; set; }
        public string GmarketSellYn { get; set; }
        public int GmarketStatCd { get; set; }
        public DateTime? Lastconfirmdate { get; set; }
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
        public string DisplayDate { get; set; }
    }
}

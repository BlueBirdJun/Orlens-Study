using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblKakaoGiftRegItem
    {
        public int Itemid { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public decimal AddDlvPrice { get; set; }
        public decimal AddKakaoPrice { get; set; }
        public string Kakaoitemname { get; set; }
        public DateTime? KakaoGiftRegdate { get; set; }
        public DateTime? KakaoGiftLastUpdate { get; set; }
        public string KakaoGiftGoodNo { get; set; }
        public string KakaoGiftGoodNo2 { get; set; }
        public string Kakaostate { get; set; }
        public string Kakaocategorycode { get; set; }
        public decimal KakaoGiftPrice { get; set; }
        public decimal? Kakaosaleprice { get; set; }
        public string KakaoGiftSellYn { get; set; }
        public int KakaoGiftStatCd { get; set; }
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
        public string Updchkdata { get; set; }
    }
}

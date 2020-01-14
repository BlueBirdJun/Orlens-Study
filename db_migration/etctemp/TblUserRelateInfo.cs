using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblUserRelateInfo
    {
        public string Userid { get; set; }
        public int LinkUserCnt { get; set; }
        public decimal BuySum { get; set; }
        public int BuyCnt { get; set; }
        public int NewUserCnt { get; set; }
        public int ReviewCnt { get; set; }
        public byte LinkUserRank { get; set; }
        public byte BuySumRank { get; set; }
        public byte BuyCntRank { get; set; }
        public byte NewUserRank { get; set; }
        public byte ReviewRank { get; set; }
    }
}

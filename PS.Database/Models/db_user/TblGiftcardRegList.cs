using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblGiftcardRegList
    {
        public int Idx { get; set; }
        public string GiftOrderSerial { get; set; }
        public int CardItemid { get; set; }
        public string CardOption { get; set; }
        public string MasterCardCode { get; set; }
        public decimal CardPrice { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime CardExpire { get; set; }
        public string Userid { get; set; }
        public string CardStatus { get; set; }
    }
}

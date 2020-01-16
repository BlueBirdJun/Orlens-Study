using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblAuction
    {
        public int Idx { get; set; }
        public int? TenItemid { get; set; }
        public string TenOption { get; set; }
        public long? AuctionRealsel { get; set; }
        public string AuctionIsusing { get; set; }
        public string AuctionCateCode { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

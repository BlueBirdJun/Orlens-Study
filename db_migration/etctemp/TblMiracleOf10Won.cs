using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMiracleOf10Won
    {
        public int Idx { get; set; }
        public DateTime Sdate { get; set; }
        public DateTime Edate { get; set; }
        public DateTime Sviewdate { get; set; }
        public DateTime Eviewdate { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductBigImg { get; set; }
        public string ProductSmallImg { get; set; }
        public int ProductPrice { get; set; }
        public int AuctionMinPrice { get; set; }
        public int AuctionMaxPrice { get; set; }
        public int? WinnerPrice { get; set; }
        public string Winneruserid { get; set; }
        public DateTime Regdate { get; set; }
        public string Isusing { get; set; }
        public int? Roundnum { get; set; }
    }
}

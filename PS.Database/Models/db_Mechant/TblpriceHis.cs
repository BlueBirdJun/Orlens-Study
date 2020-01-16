using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class TblpriceHis
    {
        public int Versionkey { get; set; }
        public int Pricekey { get; set; }
        public int Productkey { get; set; }
        public int Originpricekey { get; set; }
        public decimal? Sellprice { get; set; }
        public decimal? Buycash { get; set; }
        public decimal? Customerprice { get; set; }
        public decimal? Customerbuycash { get; set; }
        public decimal? Saleprice { get; set; }
        public decimal? Salebuyprice { get; set; }
        public DateTime Createdate { get; set; }
    }
}

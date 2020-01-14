using System;
using System.Collections.Generic;

namespace ConsoleApp1.pszero
{
    public partial class Tblprice
    {
        public int Pricekey { get; set; }
        public int Productkey { get; set; }
        public decimal? Sellprice { get; set; }
        public decimal? Buycash { get; set; }
        public decimal? Customerprice { get; set; }
        public decimal? Customerbuycash { get; set; }
        public decimal? Saleprice { get; set; }
        public decimal? Salebuyprice { get; set; }
        public DateTime Createdate { get; set; }
    }
}

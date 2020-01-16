using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblshipinfoprice
    {
        public int Shippricekey { get; set; }
        public decimal? Basicprice { get; set; }
        public decimal? Returnprice { get; set; }
        public decimal? Exchagneprice { get; set; }
        public string Shipmethod { get; set; }
        public DateTime? Createdate { get; set; }
        public int Productkey { get; set; }
        public decimal? Conditonprice { get; set; }
    }
}

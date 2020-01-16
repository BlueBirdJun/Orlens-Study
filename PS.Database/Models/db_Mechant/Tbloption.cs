using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tbloption
    {
        public int Optionkey { get; set; }
        public int Productkey { get; set; }
        public string Typename { get; set; }
        public string Optionname { get; set; }
        public int? Qty { get; set; }
        public decimal? Addprice { get; set; }
        public decimal? Addbuyprice { get; set; }
        public DateTime? Createdate { get; set; }
    }
}

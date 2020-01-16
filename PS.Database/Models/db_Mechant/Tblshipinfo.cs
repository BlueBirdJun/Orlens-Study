using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblshipinfo
    {
        public int Brandkey { get; set; }
        public int Shippricekey { get; set; }
        public string Returnaddress { get; set; }
        public string Returnaddressdetail { get; set; }
        public string Returnaddresszipcode { get; set; }
        public string Shipaddress { get; set; }
        public string Shipaddressdetail { get; set; }
        public string Shipaddresszipcode { get; set; }
        public string Shiparead { get; set; }
        public DateTime? Createdate { get; set; }
        public int Shipinfokey { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblimage
    {
        public string Url { get; set; }
        public string Useyn { get; set; }
        public string Kind { get; set; }
        public DateTime? Createdate { get; set; }
        public int Productkey { get; set; }
        public int Imagekey { get; set; }
    }
}

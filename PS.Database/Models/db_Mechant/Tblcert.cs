using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblcert
    {
        public int Certkey { get; set; }
        public string Certcode { get; set; }
        public string Content { get; set; }
        public string Useyn { get; set; }
        public DateTime? Createdate { get; set; }
        public int Productkey { get; set; }
    }
}

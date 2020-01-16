using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblsearch
    {
        public int Searchkey { get; set; }
        public string Keyword { get; set; }
        public DateTime? Createdate { get; set; }
        public int Productkey { get; set; }
    }
}

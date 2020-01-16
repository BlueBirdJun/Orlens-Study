using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Matchcategory
    {
        public int Matchkey { get; set; }
        public string Catelarge { get; set; }
        public string Catemid { get; set; }
        public string Catesmall { get; set; }
        public DateTime? Createdate { get; set; }
        public int Categorykey { get; set; }
    }
}

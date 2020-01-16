using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblcode
    {
        public int Codekey { get; set; }
        public string Code { get; set; }
        public string Kind { get; set; }
        public string Desc { get; set; }
        public DateTime? Createdate { get; set; }
    }
}

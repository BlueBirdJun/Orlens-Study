using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblversion
    {
        public string Kind { get; set; }
        public string Origin { get; set; }
        public DateTime? Starttime { get; set; }
        public string Accept { get; set; }
        public string Desc { get; set; }
        public DateTime? Endtime { get; set; }
        public DateTime? Createdate { get; set; }
        public int Versionkey { get; set; }
    }
}

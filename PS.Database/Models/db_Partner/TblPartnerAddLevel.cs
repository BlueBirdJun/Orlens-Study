using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerAddLevel
    {
        public string Userid { get; set; }
        public int PartSn { get; set; }
        public int LevelSn { get; set; }
        public string IsDefault { get; set; }
    }
}

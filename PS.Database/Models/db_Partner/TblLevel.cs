using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblLevel
    {
        public int LevelSn { get; set; }
        public int LevelNo { get; set; }
        public string LevelName { get; set; }
        public string LevelIsDel { get; set; }
    }
}

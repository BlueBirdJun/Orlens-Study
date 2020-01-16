using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateBoardPart
    {
        public int PartSn { get; set; }
        public int? LevelSn { get; set; }
        public int? PositSn { get; set; }
        public int? JobSn { get; set; }
        public int BrdSn { get; set; }
        public int DepartmentId { get; set; }
    }
}

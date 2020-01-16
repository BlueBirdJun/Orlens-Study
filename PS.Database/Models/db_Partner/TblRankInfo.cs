using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblRankInfo
    {
        public short RankSn { get; set; }
        public string RankName { get; set; }
        public string RankIsDel { get; set; }
        public short RankSort { get; set; }
    }
}

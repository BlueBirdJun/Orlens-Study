using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateBoardComment
    {
        public int CmtSn { get; set; }
        public string Id { get; set; }
        public string CmtContent { get; set; }
        public DateTime CmtRegdate { get; set; }
        public int BrdSn { get; set; }
    }
}

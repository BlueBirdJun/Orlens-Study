using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateRefer
    {
        public int Idx { get; set; }
        public int DocIdx { get; set; }
        public string ReferId { get; set; }
        public int PartSn { get; set; }
        public DateTime? ReferViewdate { get; set; }
    }
}

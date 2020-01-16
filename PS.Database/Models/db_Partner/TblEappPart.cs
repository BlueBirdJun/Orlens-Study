using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEappPart
    {
        public int EappPartIdx { get; set; }
        public int EappDepth { get; set; }
        public int Step1PartIdx { get; set; }
        public int Step2PartIdx { get; set; }
        public string EappPartName { get; set; }
        public int PartSort { get; set; }
        public bool? IsUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

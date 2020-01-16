using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPhotoBbs
    {
        public int BbsNo { get; set; }
        public string BbsId { get; set; }
        public string BbsTitle { get; set; }
        public DateTime BbsRegdate { get; set; }
        public int BbsHit { get; set; }
        public string BbsContent { get; set; }
        public string BrdIsusing { get; set; }
        public byte BrdFixed { get; set; }
    }
}

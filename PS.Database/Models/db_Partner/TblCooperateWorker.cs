using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateWorker
    {
        public int Idx { get; set; }
        public int DocIdx { get; set; }
        public string WorkerId { get; set; }
        public int PartSn { get; set; }
        public DateTime? WorkerViewdate { get; set; }
    }
}

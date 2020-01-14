using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblBreakdownRequestDetail
    {
        public int Idx { get; set; }
        public int ReqIdx { get; set; }
        public byte WorkType { get; set; }
        public string WorkTarget { get; set; }
        public byte ReqEquipment { get; set; }
        public string ReqComment { get; set; }
        public string WorkComment { get; set; }
        public string ReqCaptimage { get; set; }
        public byte WorkState { get; set; }
        public string NowWorker { get; set; }
        public DateTime WorkLastupdate { get; set; }
        public int? WorkPartSn { get; set; }
        public string Isusing { get; set; }
        public DateTime? WorkStartdate { get; set; }

        public virtual TblBreakdownRequest ReqIdxNavigation { get; set; }
    }
}

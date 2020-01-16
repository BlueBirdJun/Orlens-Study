using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPhotoSchedule
    {
        public int ScheduleNo { get; set; }
        public int? ReqNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ScheduleRegdate { get; set; }
        public int? Status { get; set; }
        public string Comment { get; set; }
        public string ReqPhoto { get; set; }
        public string ReqStylist { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPhotoReq
    {
        public int ReqNo { get; set; }
        public string ReqGubun { get; set; }
        public string ReqUse { get; set; }
        public string ReqUseDetail { get; set; }
        public string PrdName { get; set; }
        public string PrdType { get; set; }
        public int? PrdType2 { get; set; }
        public string PrdPrice { get; set; }
        public int? ImportLevel { get; set; }
        public string ReqDepartment { get; set; }
        public string ReqCategory { get; set; }
        public string Makerid { get; set; }
        public string Itemid { get; set; }
        public DateTime? ReqDate { get; set; }
        public string ReqEtc1 { get; set; }
        public string ReqUrl { get; set; }
        public string ReqEtc2 { get; set; }
        public int? ReqStatus { get; set; }
        public DateTime? ReqRegdate { get; set; }
        public string ReqComment { get; set; }
        public string UseYn { get; set; }
        public string ReqName { get; set; }
        public int? LoadReq { get; set; }
        public string FontColor { get; set; }
        public string Mdid { get; set; }
        public int? ReqCdlDisp { get; set; }
    }
}

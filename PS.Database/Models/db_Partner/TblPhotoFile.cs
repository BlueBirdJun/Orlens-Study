using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPhotoFile
    {
        public int FileNo { get; set; }
        public int? BbsNo { get; set; }
        public int? ReqNo { get; set; }
        public string FileName { get; set; }
        public string RealName { get; set; }
        public DateTime? FileRegdate { get; set; }
    }
}

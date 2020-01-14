using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblBetweenEventComment
    {
        public int EvtcomIdx { get; set; }
        public int EvtCode { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Userphone { get; set; }
        public string EvtcomTxt { get; set; }
        public int EvtcomPoint { get; set; }
        public DateTime EvtcomRegdate { get; set; }
        public string EvtcomUsing { get; set; }
        public int EvtbbsIdx { get; set; }
        public int EvtgroupCode { get; set; }
        public string Refip { get; set; }
        public string Blogurl { get; set; }
        public string Device { get; set; }
    }
}

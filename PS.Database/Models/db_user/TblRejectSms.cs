using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblRejectSms
    {
        public int Idx { get; set; }
        public string Cid { get; set; }
        public string Rejectnumber { get; set; }
        public string Receive080 { get; set; }
        public string Refip { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? AssignDate { get; set; }
        public int? AssignNo { get; set; }
    }
}

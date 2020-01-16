using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppComment
    {
        public int CommentIdx { get; set; }
        public int ReportIdx { get; set; }
        public int PayRequestIdx { get; set; }
        public string Comment { get; set; }
        public string AdminId { get; set; }
        public DateTime Regdate { get; set; }
        public bool? IsUsing { get; set; }
    }
}

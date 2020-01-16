using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppAuthLine
    {
        public int AuthLineidx { get; set; }
        public int ReportIdx { get; set; }
        public int PayRequestIdx { get; set; }
        public int Authposition { get; set; }
        public string AuthId { get; set; }
        public byte AuthState { get; set; }
        public bool IsLast { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Confirmdate { get; set; }
        public bool IsView { get; set; }
        public DateTime? Viewdate { get; set; }
        public bool? IsSms { get; set; }
        public bool? IsUsing { get; set; }
        public string IsType { get; set; }
    }
}

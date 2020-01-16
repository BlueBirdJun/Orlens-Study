using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserInouttimeLog
    {
        public int Idx { get; set; }
        public int Placeid { get; set; }
        public string Empno { get; set; }
        public string Yyyymmdd { get; set; }
        public int InoutType { get; set; }
        public DateTime InoutTime { get; set; }
        public int PosIdx { get; set; }
        public DateTime PosDate { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lasteditupdate { get; set; }
        public string Lastedituserid { get; set; }
        public string Isusing { get; set; }
    }
}

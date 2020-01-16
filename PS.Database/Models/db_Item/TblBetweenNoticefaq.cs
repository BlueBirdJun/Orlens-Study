using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblBetweenNoticefaq
    {
        public int Idx { get; set; }
        public string Gubun { get; set; }
        public string Subject { get; set; }
        public string Contents { get; set; }
        public DateTime Regdate { get; set; }
        public string Isusing { get; set; }
    }
}

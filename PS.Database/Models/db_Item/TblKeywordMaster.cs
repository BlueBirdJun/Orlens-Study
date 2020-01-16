using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblKeywordMaster
    {
        public int Idx { get; set; }
        public string Mode { get; set; }
        public string Subject { get; set; }
        public string Prekeyword { get; set; }
        public string Nextkeyword { get; set; }
        public string Etc { get; set; }
        public string Regid { get; set; }
        public DateTime Regdate { get; set; }
    }
}

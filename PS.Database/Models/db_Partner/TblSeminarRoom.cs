using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblSeminarRoom
    {
        public int Idx { get; set; }
        public string Roomname { get; set; }
        public int MaxSu { get; set; }
        public int OrderNo { get; set; }
        public string Isusing { get; set; }
    }
}

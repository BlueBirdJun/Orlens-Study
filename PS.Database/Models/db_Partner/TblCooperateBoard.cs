using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateBoard
    {
        public int BrdSn { get; set; }
        public string Id { get; set; }
        public string BrdSubject { get; set; }
        public string BrdContent { get; set; }
        public int BrdHit { get; set; }
        public DateTime BrdRegdate { get; set; }
        public byte BrdFixed { get; set; }
        public string BrdTeam { get; set; }
        public string BrdIsusing { get; set; }
        public byte BrdType { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}

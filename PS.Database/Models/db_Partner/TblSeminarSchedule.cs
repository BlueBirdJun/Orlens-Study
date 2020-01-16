using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblSeminarSchedule
    {
        public int Idx { get; set; }
        public int Roomidx { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Groupname { get; set; }
        public int Usepurpose { get; set; }
        public string Usercell { get; set; }
        public int UseSu { get; set; }
        public string Etc { get; set; }
        public int? Lecnum { get; set; }
        public string Isusing { get; set; }
        public string AdminId { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCompCalendar
    {
        public int Idx { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ImportantLevel { get; set; }
        public int OpenLevel { get; set; }
        public string UseYn { get; set; }
        public string Reguserid { get; set; }
        public string Modiuserid { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

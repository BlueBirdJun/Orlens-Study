using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblWeekwork
    {
        public int Idx { get; set; }
        public string Team { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public int? WeekNum { get; set; }
        public string Lastweek { get; set; }
        public string Thisweek { get; set; }
        public DateTime? WriteDate { get; set; }
        public DateTime? RewriteDate { get; set; }
        public int Gubun { get; set; }
        public int? WeekMonth { get; set; }
    }
}

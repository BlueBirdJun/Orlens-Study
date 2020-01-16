using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblMileageAutoExtinctionLog
    {
        public int Id { get; set; }
        public int TaskKey { get; set; }
        public string Jukyo { get; set; }
        public int? Jukyocd { get; set; }
        public DateTime? DoneDate { get; set; }
        public int? ChkPopulation { get; set; }
        public int? UpdatedUsersCnt { get; set; }
    }
}

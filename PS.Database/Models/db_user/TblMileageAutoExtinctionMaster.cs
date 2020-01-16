using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblMileageAutoExtinctionMaster
    {
        public int Id { get; set; }
        public string Jukyo { get; set; }
        public int Jukyocd { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public int? ChkDays { get; set; }
        public int? Useyn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblBetweenMain3banner
    {
        public int Idx { get; set; }
        public string Gender { get; set; }
        public string Imgurl { get; set; }
        public string Imglink { get; set; }
        public int? Sortno { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Adminid { get; set; }
        public string Lastadminid { get; set; }
        public string Isusing { get; set; }
        public DateTime? Xmlregdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblBetweenMainTopbanner
    {
        public int Idx { get; set; }
        public string Gender { get; set; }
        public string PjtKind { get; set; }
        public string Imgurl { get; set; }
        public string LinkUrl { get; set; }
        public string BanBgcolor { get; set; }
        public string PartnerNmColor { get; set; }
        public string BanTxtColor { get; set; }
        public string Bantext1 { get; set; }
        public string Bantext2 { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Adminid { get; set; }
        public string Lastadminid { get; set; }
        public string Isusing { get; set; }
        public DateTime? Xmlregdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEtcStyleMaster
    {
        public string Styleserial { get; set; }
        public string Sitename { get; set; }
        public string Dispnum { get; set; }
        public string Styletitle { get; set; }
        public string Imageon { get; set; }
        public string Imageoff { get; set; }
        public string Imagetitle { get; set; }
        public string Useimagemain { get; set; }
        public string Imagemain { get; set; }
        public string Userid { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblLfmallNotilist
    {
        public int Idx { get; set; }
        public int? Categorykey { get; set; }
        public string Itemkindcode { get; set; }
        public string Itemkindname { get; set; }
        public string Nitypecd { get; set; }
        public string Nitypenm { get; set; }
    }
}

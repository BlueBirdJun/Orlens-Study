using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMiracleof10secMaster
    {
        public int Idx { get; set; }
        public DateTime Miracledate { get; set; }
        public int Miracleprice { get; set; }
        public int? Miracleprice2 { get; set; }
        public int? Miracleprice3 { get; set; }
        public int? Miracleprice4 { get; set; }
        public int Miraclegiftitemid { get; set; }
        public DateTime Regdate { get; set; }
    }
}

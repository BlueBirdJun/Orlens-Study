using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEvent59086
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public short Question { get; set; }
        public string Comment { get; set; }
        public int LikeCnt { get; set; }
        public DateTime Regdate { get; set; }
        public string Device { get; set; }
    }
}

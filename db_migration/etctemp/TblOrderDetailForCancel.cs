using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblOrderDetailForCancel
    {
        public long Idx { get; set; }
        public int Cancelitemno { get; set; }
        public DateTime Regdate { get; set; }
    }
}

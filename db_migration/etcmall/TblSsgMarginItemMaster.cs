using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblSsgMarginItemMaster
    {
        public int Idx { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Margin { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
        public string Mallid { get; set; }
    }
}

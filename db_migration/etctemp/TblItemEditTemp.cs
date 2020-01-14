using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblItemEditTemp
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public decimal Orgprice { get; set; }
        public int Ordertempstatus { get; set; }
        public DateTime Regdate { get; set; }
        public string Isusing { get; set; }
        public string Regadminid { get; set; }
        public string Failtype { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMulti2mileage
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public decimal Amount { get; set; }
        public string Payid { get; set; }
        public string Result { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

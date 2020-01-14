using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblUserRelateList
    {
        public int Sn { get; set; }
        public string Userid { get; set; }
        public string LinkUser { get; set; }
        public string LinkDesc { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

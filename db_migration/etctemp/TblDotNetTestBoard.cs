using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblDotNetTestBoard
    {
        public int Idx { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Userid { get; set; }
        public DateTime Regdate { get; set; }
        public string Isusing { get; set; }
    }
}

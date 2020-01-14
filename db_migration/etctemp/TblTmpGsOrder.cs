using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblTmpGsOrder
    {
        public int Idx { get; set; }
        public DateTime Regdate { get; set; }
        public string Refip { get; set; }
        public string XmlData { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblSabannetLog
    {
        public int Idx { get; set; }
        public string Title { get; set; }
        public int? Getcount { get; set; }
        public string Getcontents { get; set; }
        public DateTime Regdate { get; set; }
    }
}

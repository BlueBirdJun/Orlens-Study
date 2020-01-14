using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblExportCsv
    {
        public int Idx { get; set; }
        public string SqlStr { get; set; }
        public string ColumnNames { get; set; }
        public string Params { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

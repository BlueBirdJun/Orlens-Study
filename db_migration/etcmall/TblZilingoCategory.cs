using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblZilingoCategory
    {
        public int Idx { get; set; }
        public string Depth1Name { get; set; }
        public string Depth2Name { get; set; }
        public string Depth2Code { get; set; }
        public string Depth3Name { get; set; }
        public string Depth3Code { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblZilingoSubCategory
    {
        public int Idx { get; set; }
        public string Gubun { get; set; }
        public string Depth1Id { get; set; }
        public string Depth1Name { get; set; }
        public string Depth2Id { get; set; }
        public string Depth2Name { get; set; }
        public string Depth3Id { get; set; }
        public string Depth3Name { get; set; }
        public string IsOptional { get; set; }
        public string IsMultiSelectable { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblZilingoAttrMapping
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Attributes { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblDiaryDecoItemRanking
    {
        public DateTime Rankdate { get; set; }
        public int Itemid { get; set; }
        public int Itemscore { get; set; }
        public int Catecode { get; set; }
    }
}

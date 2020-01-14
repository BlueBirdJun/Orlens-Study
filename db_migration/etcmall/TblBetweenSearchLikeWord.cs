using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblBetweenSearchLikeWord
    {
        public int Idx { get; set; }
        public int Rank { get; set; }
        public string Likeword { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}

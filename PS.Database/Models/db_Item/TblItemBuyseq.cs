using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemBuyseq
    {
        public int Baseitem { get; set; }
        public int Targetitem { get; set; }
        public int Frequence { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblGiftcardCurrent
    {
        public string Userid { get; set; }
        public decimal CurrentCash { get; set; }
        public decimal GainCash { get; set; }
        public decimal SpendCash { get; set; }
        public decimal RefundCash { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

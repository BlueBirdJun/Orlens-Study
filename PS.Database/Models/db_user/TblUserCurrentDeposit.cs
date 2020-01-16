using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserCurrentDeposit
    {
        public string Userid { get; set; }
        public decimal Currentdeposit { get; set; }
        public decimal Gaindeposit { get; set; }
        public decimal Spenddeposit { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

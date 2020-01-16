using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserCouponOpenlist
    {
        public int Masteridx { get; set; }
        public string Userid { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

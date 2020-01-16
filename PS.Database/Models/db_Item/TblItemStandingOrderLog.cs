using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemStandingOrderLog
    {
        public int Logidx { get; set; }
        public int Orgitemid { get; set; }
        public string Orgitemoption { get; set; }
        public int Sendkey { get; set; }
        public string ReserveItemName { get; set; }
        public string ReserveDlvDate { get; set; }
        public string ReserveItemGubun { get; set; }
        public int? ReserveItemId { get; set; }
        public string ReserveItemOption { get; set; }
        public int? Reserveidx { get; set; }
        public DateTime Regdate { get; set; }
        public string Regadminid { get; set; }
        public int Totalsendkey { get; set; }
    }
}

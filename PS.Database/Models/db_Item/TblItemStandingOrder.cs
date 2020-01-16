using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemStandingOrder
    {
        public int Orgitemid { get; set; }
        public string Orgitemoption { get; set; }
        public int Reserveidx { get; set; }
        public string ReserveItemName { get; set; }
        public string ReserveDlvDate { get; set; }
        public string ReserveItemGubun { get; set; }
        public int? ReserveItemId { get; set; }
        public string ReserveItemOption { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Regadminid { get; set; }
        public string Lastadminid { get; set; }
        public int? TotalsendkeyX { get; set; }
        public int? SendkeyX { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblMileagelog
    {
        public decimal Id { get; set; }
        public string Userid { get; set; }
        public int Mileage { get; set; }
        public int Jukyocd { get; set; }
        public string Jukyo { get; set; }
        public DateTime Regdate { get; set; }
        public string Orderserial { get; set; }
        public int? Itemid { get; set; }
        public string ItemOption { get; set; }
        public string Deleteyn { get; set; }
        public string Reguserid { get; set; }
        public DateTime? Deldate { get; set; }
    }
}

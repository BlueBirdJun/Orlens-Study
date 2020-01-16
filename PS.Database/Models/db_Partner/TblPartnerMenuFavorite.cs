using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerMenuFavorite
    {
        public string Userid { get; set; }
        public int MenuId { get; set; }
        public string UseYn { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblColorfavorite
    {
        public int Favoriteidx { get; set; }
        public int Colorcode { get; set; }
        public string Userid { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblSpecialShopitem
    {
        public int Idx { get; set; }
        public int Id { get; set; }
        public int Itemid { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

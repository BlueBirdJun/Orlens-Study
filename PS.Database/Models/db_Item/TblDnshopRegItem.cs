using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblDnshopRegItem
    {
        public int Itemid { get; set; }
        public DateTime? Regdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime? Dnshoplastupdate { get; set; }
    }
}

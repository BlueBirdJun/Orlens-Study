using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblBaljuregItem
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Reguserid { get; set; }
        public string Divcd { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

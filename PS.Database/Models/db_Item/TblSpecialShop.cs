using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblSpecialShop
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public DateTime Regdate { get; set; }
        public string Isusing { get; set; }
    }
}

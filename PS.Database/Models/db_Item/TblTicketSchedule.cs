using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblTicketSchedule
    {
        public int TkItemid { get; set; }
        public string TkItemoption { get; set; }
        public DateTime TkStSchedule { get; set; }
        public DateTime TkEdSchedule { get; set; }
        public DateTime ReturnExpireDate { get; set; }
    }
}

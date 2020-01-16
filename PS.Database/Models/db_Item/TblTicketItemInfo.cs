using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblTicketItemInfo
    {
        public int Itemid { get; set; }
        public DateTime StDt { get; set; }
        public DateTime EdDt { get; set; }
        public DateTime BookingStDt { get; set; }
        public DateTime BookingEdDt { get; set; }
        public decimal BookingCharge { get; set; }
        public int TicketDlvType { get; set; }
        public int RefundInfoType { get; set; }
        public int TicketPlaceIdx { get; set; }
        public string TxplayTimInfo { get; set; }
        public string TxGenre { get; set; }
        public string TxGrade { get; set; }
        public string TxRunTime { get; set; }
    }
}

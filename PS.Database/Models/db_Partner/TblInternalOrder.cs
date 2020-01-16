using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblInternalOrder
    {
        public int Idx { get; set; }
        public string Divcd { get; set; }
        public string AppDate { get; set; }
        public string SellbizsectionCd { get; set; }
        public string BuybizsectionCd { get; set; }
        public decimal TotalSum { get; set; }
        public decimal SupplySum { get; set; }
        public decimal TaxSum { get; set; }
        public string Vatyn { get; set; }
        public DateTime? Regdate { get; set; }
        public string Reguserid { get; set; }
        public string Selluserid { get; set; }
        public string Buyuserid { get; set; }
        public string Useyn { get; set; }
        public DateTime? Deldate { get; set; }
        public string AccCd { get; set; }
    }
}

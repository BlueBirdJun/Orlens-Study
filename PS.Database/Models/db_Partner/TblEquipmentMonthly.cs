using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEquipmentMonthly
    {
        public string Yyyymm { get; set; }
        public int Idx { get; set; }
        public string AccountGubun { get; set; }
        public string BizsectionCd { get; set; }
        public DateTime BuyDate { get; set; }
        public decimal BuySum { get; set; }
        public decimal BuyCost { get; set; }
        public int State { get; set; }
        public DateTime? OutDate { get; set; }
        public decimal MonthDownValue { get; set; }
        public decimal MonthRemainValue { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

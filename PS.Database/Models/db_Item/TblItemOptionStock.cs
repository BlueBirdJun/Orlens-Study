using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemOptionStock
    {
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Barcode { get; set; }
        public string Limitsellyn { get; set; }
        public int? Limitsellno { get; set; }
        public int? Limitsoldno { get; set; }
        public int? Currstockno { get; set; }
        public DateTime? Stockreipgodate { get; set; }
        public string Upchemanagecode { get; set; }
        public int? DayForSellCount { get; set; }
        public int? DayForSafeStock { get; set; }
        public int? DayForLeadTime { get; set; }
        public int? DayForMaxStock { get; set; }
        public string Upcheitemcode { get; set; }
        public string Upcheoptioncode { get; set; }
    }
}

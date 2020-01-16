using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblPublicBarcodeReserved
    {
        public int Idx { get; set; }
        public string Barcode { get; set; }
        public int? Itemid { get; set; }
        public string Itemoption { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? ReservedDate { get; set; }
        public string ReservedCont { get; set; }
        public string Itemgubun { get; set; }
        public string Reguserid { get; set; }
    }
}

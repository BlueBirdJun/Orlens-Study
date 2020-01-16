using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblOutMallEtcLink
    {
        public int Itemid { get; set; }
        public string Mallid { get; set; }
        public string Linkgbn { get; set; }
        public string Linkyn { get; set; }
        public int Valtype { get; set; }
        public int? Intval { get; set; }
        public string ShortVal { get; set; }
        public string TextVal { get; set; }
        public DateTime StDt { get; set; }
        public DateTime EdDt { get; set; }
        public DateTime? Regdate { get; set; }
        public string MadeDate { get; set; }
        public string UseDate { get; set; }
    }
}

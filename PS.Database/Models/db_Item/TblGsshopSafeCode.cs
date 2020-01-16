using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblGsshopSafeCode
    {
        public int Itemid { get; set; }
        public string SafeCertGbnCd { get; set; }
        public string SafeCertOrgCd { get; set; }
        public string SafeCertModelNm { get; set; }
        public string SafeCertNo { get; set; }
        public DateTime? SafeCertDt { get; set; }
    }
}

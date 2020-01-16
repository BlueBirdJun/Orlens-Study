using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblSafetycertTenReg
    {
        public int Itemid { get; set; }
        public string CertNum { get; set; }
        public string SafetyDiv { get; set; }
        public DateTime Regdate { get; set; }
    }
}

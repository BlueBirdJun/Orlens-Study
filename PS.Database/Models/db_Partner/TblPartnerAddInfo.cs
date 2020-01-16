using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerAddInfo
    {
        public string Partnerid { get; set; }
        public string PadminUrl { get; set; }
        public string PadminId { get; set; }
        public string PadminPwd { get; set; }
        public int PmallSellType { get; set; }
        public int PcomType { get; set; }
    }
}

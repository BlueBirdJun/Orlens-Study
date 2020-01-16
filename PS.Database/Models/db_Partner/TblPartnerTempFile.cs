using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerTempFile
    {
        public int FileIdx { get; set; }
        public int Tidx { get; set; }
        public string FileName { get; set; }
        public string RealName { get; set; }
    }
}

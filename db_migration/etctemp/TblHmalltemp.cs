using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblHmalltemp
    {
        public int Idx { get; set; }
        public string SlitmCd { get; set; }
        public string Stcd { get; set; }
        public string ItemName { get; set; }
        public string VendorItemid { get; set; }
        public string StateName { get; set; }
        public DateTime? RegDate { get; set; }
        public string Regstate { get; set; }
    }
}

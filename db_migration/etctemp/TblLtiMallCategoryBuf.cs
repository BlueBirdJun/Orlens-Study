using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblLtiMallCategoryBuf
    {
        public string CateKey { get; set; }
        public string CateGbn { get; set; }
        public string LCode { get; set; }
        public string MCode { get; set; }
        public string SCode { get; set; }
        public string DCode { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public string SName { get; set; }
        public string DName { get; set; }
        public DateTime Lastupdate { get; set; }
        public string IsUsing { get; set; }
    }
}

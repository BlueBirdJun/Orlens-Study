using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblCjmallCategory
    {
        public string CateKey { get; set; }
        public string Categbn { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public string SName { get; set; }
        public string DName { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Isusing { get; set; }
    }
}

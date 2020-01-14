using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblBackupDispCateSecretSale
    {
        public int Itemid { get; set; }
        public long Catecode { get; set; }
        public string Isdefault { get; set; }
        public DateTime BackupDate { get; set; }
    }
}

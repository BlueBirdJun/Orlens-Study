using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblBackupItemCateSecretSale
    {
        public int Itemid { get; set; }
        public string CodeLarge { get; set; }
        public string CodeMid { get; set; }
        public string CodeSmall { get; set; }
        public string CodeDiv { get; set; }
        public DateTime BackupDate { get; set; }
    }
}

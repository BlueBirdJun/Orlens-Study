using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblBreakdownWorkCode
    {
        public int PartSn { get; set; }
        public byte WorkType { get; set; }
        public string WorkTarget { get; set; }
        public string WorkTypeName { get; set; }
        public string WorkTargetName { get; set; }
        public byte WorkSortno { get; set; }
        public string WorkUseyn { get; set; }
    }
}

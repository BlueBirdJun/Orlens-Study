using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblTempPushtarget405
    {
        public string Userid { get; set; }
        public int CurrLevel { get; set; }
        public int PlusTenBuyCount { get; set; }
        public int PlusFingerBuyCount { get; set; }
        public decimal TenBuySum { get; set; }
        public decimal FingerBuySum { get; set; }
        public int? TargetIdx { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblBreakdownComCode
    {
        public string CodeType { get; set; }
        public byte CodeValue { get; set; }
        public string CodeComp { get; set; }
        public string CodeProd { get; set; }
        public string CodeDesc { get; set; }
        public string CodeUseyn { get; set; }
        public int? CodeSort { get; set; }
    }
}

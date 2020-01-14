using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblWaitItemoption
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Isusing { get; set; }
        public string Optsellyn { get; set; }
        public string Optlimityn { get; set; }
        public int? Optlimitno { get; set; }
        public int? Optlimitsold { get; set; }
        public string OptionTypeName { get; set; }
        public string Optionname { get; set; }
        public string Optionimage { get; set; }
        public decimal? OptaddPrice { get; set; }
        public decimal? OptaddBuyPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblForeignMallRegedoption
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Mallid { get; set; }
        public string OutmallOptCode { get; set; }
        public string OutmallOptName { get; set; }
        public string OutmallSellyn { get; set; }
        public string Outmalllimityn { get; set; }
        public int Outmalllimitno { get; set; }
        public decimal OutmallAddPrice { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? Checkdate { get; set; }
    }
}

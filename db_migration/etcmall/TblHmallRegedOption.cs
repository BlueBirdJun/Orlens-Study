using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblHmallRegedOption
    {
        public int Itemid { get; set; }
        public string OutmallOptCode { get; set; }
        public string OutmallOptName { get; set; }
        public string OutmallSellyn { get; set; }
        public int Outmalllimitno { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Itemoption { get; set; }
    }
}

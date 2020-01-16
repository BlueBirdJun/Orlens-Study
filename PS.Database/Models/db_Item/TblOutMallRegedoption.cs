using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblOutMallRegedoption
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
        public string OutmallleadTime { get; set; }
        public decimal? OutmallsuppPrc { get; set; }
    }
}

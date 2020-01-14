using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEpshopFixedprice
    {
        public int Itemid { get; set; }
        public decimal Sellcash { get; set; }
        public decimal Fixedcash { get; set; }
        public string Useyn { get; set; }
        public DateTime Regdt { get; set; }
        public DateTime? Upddt { get; set; }
        public string Reguserid { get; set; }
    }
}

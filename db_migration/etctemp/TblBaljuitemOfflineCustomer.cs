using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblBaljuitemOfflineCustomer
    {
        public int Baljuid { get; set; }
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Rackcode { get; set; }
        public string Makerid { get; set; }
        public string Itemname { get; set; }
        public string Itemoptionname { get; set; }
        public decimal? Orgsellprice { get; set; }
        public int? Baljuno { get; set; }
        public int? Ipgono { get; set; }
        public int? Printno { get; set; }
        public string Smallimage { get; set; }
        public string Listimage { get; set; }
        public string Itemrackcode { get; set; }
    }
}

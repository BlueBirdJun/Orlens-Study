using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteEtcItemLink
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string MallId { get; set; }
        public string Outmallitemid { get; set; }
        public string Outmallitemname { get; set; }
        public string OutmallitemOptionname { get; set; }
        public decimal? OutmallPrice { get; set; }
        public string OutmallSellYn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblShopjumunOrdertemp
    {
        public int Idx { get; set; }
        public string Yyyymmdd { get; set; }
        public string Shopid { get; set; }
        public string Barcode { get; set; }
        public string Itemgubun { get; set; }
        public int? Itemid { get; set; }
        public string Itemoption { get; set; }
        public int Ordertempstatus { get; set; }
        public decimal Sellprice { get; set; }
        public int Itemno { get; set; }
        public DateTime Regdate { get; set; }
        public string Isusing { get; set; }
        public string Regadminid { get; set; }
        public string Failtype { get; set; }
        public int? Shopjumundetailidx { get; set; }
    }
}

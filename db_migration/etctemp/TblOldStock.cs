using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblOldStock
    {
        public string Yyyymm { get; set; }
        public string Stockplace { get; set; }
        public string Shopid { get; set; }
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string TargetGbn { get; set; }
        public string Lastmakerid { get; set; }
        public string Lastmwdiv { get; set; }
        public string Lastvatinclude { get; set; }
        public int Sysstock { get; set; }
        public decimal Sysstocksum { get; set; }
        public decimal SysstocksumNoVat { get; set; }
        public string Barcode { get; set; }
    }
}

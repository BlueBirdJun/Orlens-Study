using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMonthlyStockIpgoLedgerSumTemp
    {
        public string Yyyymm { get; set; }
        public string StockPlace { get; set; }
        public string Shopid { get; set; }
        public string TargetGbn { get; set; }
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string IpgoMwdiv { get; set; }
        public string ItemMwdiv { get; set; }
        public string ItemVatInclude { get; set; }
        public int TotItemNo { get; set; }
        public decimal TotBuyCash { get; set; }
        public DateTime Lastupdate { get; set; }
        public string IpgoType { get; set; }
        public string Lastmwdiv { get; set; }
        public string Lastmakerid { get; set; }
        public string Lastvatinclude { get; set; }
        public string LastIpgoCode { get; set; }
        public decimal? LastIpgoBuyCash { get; set; }
    }
}

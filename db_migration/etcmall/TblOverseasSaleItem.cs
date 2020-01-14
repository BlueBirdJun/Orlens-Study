using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOverseasSaleItem
    {
        public int SaleitemIdx { get; set; }
        public int SaleCode { get; set; }
        public int Itemid { get; set; }
        public decimal? Saleprice { get; set; }
        public decimal? Salesupplycash { get; set; }
        public byte SaleItemStatus { get; set; }
        public int Limitno { get; set; }
        public string Orglimityn { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? Closedate { get; set; }
        public DateTime? Opendate { get; set; }
        public decimal? Orgsailprice { get; set; }
        public decimal? Orgsailsuplycash { get; set; }
        public string Orgsailyn { get; set; }
    }
}

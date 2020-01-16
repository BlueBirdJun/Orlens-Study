using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblInternalOrderDetail
    {
        public int Idx { get; set; }
        public int Masteridx { get; set; }
        public string Shopid { get; set; }
        public string Makerid { get; set; }
        public decimal TotalSum { get; set; }
        public decimal SupplySum { get; set; }
        public decimal TaxSum { get; set; }
        public string Sitename { get; set; }
        public string Meachulgubun { get; set; }
        public int? Sitefee { get; set; }
        public decimal? Totalsellcash { get; set; }
        public decimal? Totalchulgocash { get; set; }
        public decimal? Totalbuycash { get; set; }
        public int? Innerorderpercentage { get; set; }
        public string Itemdiv { get; set; }
        public string Pricediv { get; set; }
        public string Dealdiv { get; set; }
    }
}

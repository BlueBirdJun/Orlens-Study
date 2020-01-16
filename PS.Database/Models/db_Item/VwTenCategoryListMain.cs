using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class VwTenCategoryListMain
    {
        public int Itemid { get; set; }
        public string Itemname { get; set; }
        public decimal Sellcash { get; set; }
        public decimal Orgprice { get; set; }
        public string Makerid { get; set; }
        public string Brandname { get; set; }
        public string Listimage { get; set; }
        public string Icon1image { get; set; }
        public string Sellyn { get; set; }
        public string SaleYn { get; set; }
        public string Limityn { get; set; }
        public int? Limitno { get; set; }
        public int? Limitsold { get; set; }
        public string Itemcouponyn { get; set; }
        public int? Itemcouponvalue { get; set; }
        public string Itemcoupontype { get; set; }
        public int Evalcnt { get; set; }
        public int? Itemscore { get; set; }
        public string CodeDiv { get; set; }
        public DateTime? Regdate { get; set; }
        public string CodeLarge { get; set; }
    }
}

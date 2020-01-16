using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblShoplinkerOutmall
    {
        public int Itemid { get; set; }
        public string Makerid { get; set; }
        public string MallUserId { get; set; }
        public string MallName { get; set; }
        public string ShoplinkerId { get; set; }
        public string ProductId { get; set; }
        public string MallProductId { get; set; }
        public string MallProductName { get; set; }
        public int? SupplyPrice { get; set; }
        public int? SalePrice { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

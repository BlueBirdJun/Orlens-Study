using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class VwOpenItemViewAgirl
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Sellyn { get; set; }
        public string Limityn { get; set; }
        public int? LimitNo { get; set; }
        public int? LimitSold { get; set; }
        public string Itemusing { get; set; }
        public string Itemname { get; set; }
        public string Optionname { get; set; }
        public string SmallImage { get; set; }
        public decimal OrgPrice { get; set; }
        public decimal Sellcash { get; set; }
        public decimal Optaddprice { get; set; }
        public string ItemSellYn { get; set; }
        public string ItemUsingYn { get; set; }
        public string DeliveryType { get; set; }
        public int AgirlItemSeq { get; set; }
        public string AgirlOptionCode { get; set; }
        public byte LinkStockType { get; set; }
    }
}

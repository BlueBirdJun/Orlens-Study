using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblGiftcardOption
    {
        public int CardItemid { get; set; }
        public string CardOption { get; set; }
        public string CardOptionName { get; set; }
        public decimal CardSellCash { get; set; }
        public decimal CardSalePrice { get; set; }
        public decimal CardOrgPrice { get; set; }
        public string CardSaleYn { get; set; }
        public string OptSellYn { get; set; }
        public string OptIsUsing { get; set; }
    }
}

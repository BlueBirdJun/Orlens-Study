using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblITsItemLink
    {
        public int ItemSeq { get; set; }
        public string OptionCode { get; set; }
        public string ItemName { get; set; }
        public string OptionCodeName { get; set; }
        public string Barcode { get; set; }
        public decimal ConsumerPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal SupplyPrice { get; set; }
        public decimal? SubProductPrice { get; set; }
        public decimal? ProductPrice { get; set; }
        public string LastItsipgoMonth { get; set; }
    }
}

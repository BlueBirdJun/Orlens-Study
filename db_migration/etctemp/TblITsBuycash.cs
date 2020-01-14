using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblITsBuycash
    {
        public string Itemgubun { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Barcode { get; set; }
        public decimal Pbuycash { get; set; }
        public decimal Itsbuycash { get; set; }
        public decimal Psellcash { get; set; }
        public decimal ITsSellcash { get; set; }
        public decimal OptAddprice { get; set; }
    }
}

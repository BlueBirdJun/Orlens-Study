using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblPlusSaleRegedItemBack
    {
        public int PlusSaleItemId { get; set; }
        public int PlusSalePro { get; set; }
        public double PlusSaleMargin { get; set; }
        public string PlusSaleMaginFlag { get; set; }
        public DateTime PlusSaleStartDate { get; set; }
        public DateTime PlusSaleEndDate { get; set; }
        public DateTime? Regdate { get; set; }
    }
}

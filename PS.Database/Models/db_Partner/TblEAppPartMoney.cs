using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppPartMoney
    {
        public int PartMoneyIdx { get; set; }
        public int ReportIdx { get; set; }
        public int PayRequestIdx { get; set; }
        public string BizSectionCd { get; set; }
        public int? EappPartIdx { get; set; }
        public decimal PartMoney { get; set; }
        public bool? IsUsing { get; set; }
    }
}

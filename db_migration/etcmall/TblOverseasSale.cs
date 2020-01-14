using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOverseasSale
    {
        public string Sitename { get; set; }
        public int SaleCode { get; set; }
        public string SaleGubun { get; set; }
        public int SaleRate { get; set; }
        public DateTime? SaleStartdate { get; set; }
        public DateTime? SaleEnddate { get; set; }
        public byte SaleStatus { get; set; }
        public DateTime? Opendate { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public bool? SaleUsing { get; set; }
        public string Adminid { get; set; }
        public DateTime? Closedate { get; set; }
    }
}

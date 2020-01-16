using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOpExpPart
    {
        public int OpExpPartidx { get; set; }
        public int PartTypeidx { get; set; }
        public string OpExpPartName { get; set; }
        public string OutBank { get; set; }
        public string OutAccNo { get; set; }
        public string OutName { get; set; }
        public string CardCo { get; set; }
        public string CardNo { get; set; }
        public string BizsectionCd { get; set; }
        public decimal? ArapCd { get; set; }
        public int? EapppArtiDx { get; set; }
        public string CustCd { get; set; }
        public int? OrderNo { get; set; }
        public string Adminid { get; set; }
        public bool? IsUsing { get; set; }
    }
}

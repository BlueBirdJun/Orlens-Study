using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblOnlineAppLogTmp
    {
        public string Pggubun { get; set; }
        public string Pgkey { get; set; }
        public string Pgcskey { get; set; }
        public string Sitename { get; set; }
        public string AppDivCode { get; set; }
        public string AppMethod { get; set; }
        public DateTime? AppDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public decimal AppPrice { get; set; }
        public decimal CommPrice { get; set; }
        public decimal CommVatPrice { get; set; }
        public decimal JungsanPrice { get; set; }
        public string Ipkumdate { get; set; }
        public string Pguserid { get; set; }
        public string PgmeachulDate { get; set; }
        public string Orderserial { get; set; }
        public decimal? EtcPoint { get; set; }
    }
}

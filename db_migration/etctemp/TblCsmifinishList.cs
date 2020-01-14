using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblCsmifinishList
    {
        public int Idx { get; set; }
        public int Csdetailidx { get; set; }
        public string Orderserial { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public int Itemno { get; set; }
        public int? Itemlackno { get; set; }
        public string Code { get; set; }
        public string State { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Ipgodate { get; set; }
        public string Reqstr { get; set; }
        public string Finishstr { get; set; }
        public string Itemname { get; set; }
        public string Itemoptionname { get; set; }
        public string IsSendSms { get; set; }
        public string IsSendEmail { get; set; }
        public string IsSendCall { get; set; }
        public string Reguserid { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

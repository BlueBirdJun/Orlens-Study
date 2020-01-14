using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMibeasongList
    {
        public int Idx { get; set; }
        public int Detailidx { get; set; }
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
        public string Reqaddstr { get; set; }
        public string Prevcode { get; set; }
        public string Reguserid { get; set; }
        public string Modiuserid { get; set; }
        public DateTime? Modidate { get; set; }
        public int? SendCount { get; set; }
        public string LastSendUserid { get; set; }
        public DateTime? LastSendDate { get; set; }
        public string Reqreguserid { get; set; }
        public string IsSendApi { get; set; }
    }
}

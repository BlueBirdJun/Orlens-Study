using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TmpRawCtr
    {
        public string Groupid { get; set; }
        public string Comname { get; set; }
        public string CompanyNo { get; set; }
        public string Ceoname { get; set; }
        public string Compaddr { get; set; }
        public string Jungsandate { get; set; }
        public string Brandid { get; set; }
        public string Sellplace { get; set; }
        public string Mwdiv { get; set; }
        public int? Defaultmargin { get; set; }
        public int? Mcnt { get; set; }
        public int? Wcnt { get; set; }
        public int? Ucnt { get; set; }
        public string Catecode { get; set; }
        public int? Contracttype { get; set; }
        public string Catename { get; set; }
        public string Contractname { get; set; }
        public string Ctrno { get; set; }
        public int? Ctrstate { get; set; }
        public DateTime? Regdate { get; set; }
        public string Reguserid { get; set; }
        public string Senduserid { get; set; }
        public string Finuserid { get; set; }
    }
}

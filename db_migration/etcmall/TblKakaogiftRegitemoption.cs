using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblKakaogiftRegitemoption
    {
        public int Itemid { get; set; }
        public string OutmallCode { get; set; }
        public string OutmallCode2 { get; set; }
        public string Optioncode { get; set; }
        public string OutmallOptionCode { get; set; }
        public string OptionName { get; set; }
        public int? LimitNo { get; set; }
        public string SellYn { get; set; }
        public string VisibleYn { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string SyncYn { get; set; }
        public DateTime Regdate { get; set; }
        public string Typename { get; set; }
    }
}

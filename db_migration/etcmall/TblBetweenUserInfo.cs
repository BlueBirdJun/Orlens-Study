using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblBetweenUserInfo
    {
        public int UserSn { get; set; }
        public string BtwUserCd { get; set; }
        public string Gender { get; set; }
        public string Userid { get; set; }
        public string PtnUserCd { get; set; }
        public string PtnGender { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}

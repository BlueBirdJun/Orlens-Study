using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblGiftcardLog
    {
        public int Idx { get; set; }
        public string Userid { get; set; }
        public decimal UseCash { get; set; }
        public int Jukyocd { get; set; }
        public string Jukyo { get; set; }
        public string Orderserial { get; set; }
        public string DeleteYn { get; set; }
        public string Reguserid { get; set; }
        public string Deluserid { get; set; }
        public DateTime Regdate { get; set; }
        public string SiteDiv { get; set; }
        public string NotRegGiftOrderSerial { get; set; }
        public string Fixyyyymmdd { get; set; }
        public string Fixyyyymmdd20121130before { get; set; }
    }
}

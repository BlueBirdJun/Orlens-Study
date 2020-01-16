using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class XTblUserSsnV2
    {
        public string SsnHash { get; set; }
        public string Ssnuserid { get; set; }
        public string Ssnlogindt { get; set; }
        public DateTime Lastupdate { get; set; }
        public int SsnkeepAddtime { get; set; }
        public DateTime Regdate { get; set; }
        public string Lgnchannel { get; set; }
        public string Ssndata { get; set; }
    }
}

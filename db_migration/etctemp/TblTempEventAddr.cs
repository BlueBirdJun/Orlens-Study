using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblTempEventAddr
    {
        public int Idx { get; set; }
        public int? EvtCode { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Usercell { get; set; }
        public string Zipcode { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Device { get; set; }
        public int? Etc1 { get; set; }
        public string Etc2 { get; set; }
    }
}

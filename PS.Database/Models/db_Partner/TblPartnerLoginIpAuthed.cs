using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerLoginIpAuthed
    {
        public string Userid { get; set; }
        public string Refip { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? LastAuthdate { get; set; }
    }
}

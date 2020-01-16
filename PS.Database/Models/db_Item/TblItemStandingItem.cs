using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemStandingItem
    {
        public int Orgitemid { get; set; }
        public string Orgitemoption { get; set; }
        public int Startreserveidx { get; set; }
        public int Endreserveidx { get; set; }
    }
}

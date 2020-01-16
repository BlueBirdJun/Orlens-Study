using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserInouttimePlace
    {
        public int Placeid { get; set; }
        public string Placeiname { get; set; }
        public int? Validpart { get; set; }
        public string Isusing { get; set; }
    }
}

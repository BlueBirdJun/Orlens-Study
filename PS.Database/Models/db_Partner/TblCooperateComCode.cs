using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateComCode
    {
        public string CodeType { get; set; }
        public byte CodeValue { get; set; }
        public string CodeDesc { get; set; }
        public string CodeUseyn { get; set; }
        public int? CodeSort { get; set; }
    }
}

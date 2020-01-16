using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOpExpPartType
    {
        public int PartTypeidx { get; set; }
        public string PartTypeName { get; set; }
        public bool? IsUsing { get; set; }
        public bool? IsCard { get; set; }
    }
}

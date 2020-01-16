using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppPayRequestSubList
    {
        public int PayRequestSubIdx { get; set; }
        public int PayRequestIdx { get; set; }
        public int RefType { get; set; }
        public int RefKey { get; set; }
        public int? PayState { get; set; }
        public string ErpKey { get; set; }
    }
}

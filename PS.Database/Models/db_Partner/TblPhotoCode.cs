using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPhotoCode
    {
        public int CodeNo { get; set; }
        public string CodeType { get; set; }
        public int CodeValue { get; set; }
        public string CodeName { get; set; }
        public int CodeSort { get; set; }
        public string CodeUseyn { get; set; }
    }
}

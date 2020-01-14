using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblInterparkTmpDispCategory
    {
        public string DispCateCode { get; set; }
        public string DispCateName { get; set; }
        public string Dispyn { get; set; }
        public DateTime? LastRegDate { get; set; }
        public string IParkregDts { get; set; }
        public string IParkmodDts { get; set; }
        public string IsLifeCate { get; set; }
        public string IsElecCate { get; set; }
        public string IsChildrenCate { get; set; }
    }
}

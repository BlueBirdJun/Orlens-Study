using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblDisplayTotalcategory
    {
        public long Catecode { get; set; }
        public long ParentCatecode { get; set; }
        public string CateName { get; set; }
        public string CateName2 { get; set; }
        public int? Lv { get; set; }
        public int? SortNo { get; set; }
        public string LastcatecodeYn { get; set; }
    }
}

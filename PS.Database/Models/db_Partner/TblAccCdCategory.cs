using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblAccCdCategory
    {
        public int AccCateIdx { get; set; }
        public string AccCateName { get; set; }
        public int AccDepth { get; set; }
        public int AccPcateIdx { get; set; }
        public int? AccOrder { get; set; }
        public bool? IsUsing { get; set; }
        public DateTime Regdate { get; set; }
    }
}

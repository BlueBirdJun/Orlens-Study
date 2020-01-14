using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblLotteiMallCategory
    {
        public string DispNo { get; set; }
        public string DispNm { get; set; }
        public string DispLrgNm { get; set; }
        public string DispMidNm { get; set; }
        public string DispSmlNm { get; set; }
        public string DispThnNm { get; set; }
        public int GroupCode { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Disptpcd { get; set; }
        public string IsUsing { get; set; }
    }
}

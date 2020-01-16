using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCompanyState
    {
        public string CompanyNo { get; set; }
        public string Regstat { get; set; }
        public string Vatgubun { get; set; }
        public DateTime? Closuredate { get; set; }
        public DateTime? Vatconvdate { get; set; }
        public DateTime Upddt { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblMileageMonthlyExpire
    {
        public int Expireidx { get; set; }
        public string Yyyymm { get; set; }
        public string Userid { get; set; }
        public decimal BonusMileage { get; set; }
        public decimal OrderMileage { get; set; }
        public decimal OrderMinusMileage { get; set; }
        public decimal SpendMileage { get; set; }
        public decimal EapiredMileage { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? Procdate { get; set; }
    }
}

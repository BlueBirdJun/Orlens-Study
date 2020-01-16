using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblMileageYearExpire
    {
        public string RegYear { get; set; }
        public string Userid { get; set; }
        public string Expiredate { get; set; }
        public decimal Bonusgainmileage { get; set; }
        public decimal Ordergainmileage { get; set; }
        public decimal Orderminusmileage { get; set; }
        public decimal PreYearAssignedSpendmileage { get; set; }
        public decimal RealExpiredMileage { get; set; }
    }
}

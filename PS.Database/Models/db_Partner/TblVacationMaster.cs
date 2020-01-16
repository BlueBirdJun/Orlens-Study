using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblVacationMaster
    {
        public int Idx { get; set; }
        public string Empno { get; set; }
        public string Userid { get; set; }
        public string Divcd { get; set; }
        public string Yyyy { get; set; }
        public DateTime Startday { get; set; }
        public DateTime Endday { get; set; }
        public double Totalvacationday { get; set; }
        public double Usedvacationday { get; set; }
        public double Requestedday { get; set; }
        public string Deleteyn { get; set; }
        public string Registerid { get; set; }
        public DateTime Regdate { get; set; }
        public double? PromotionDay { get; set; }
        public double? JungsanDay { get; set; }
        public double? RetireJungsanDay { get; set; }
    }
}

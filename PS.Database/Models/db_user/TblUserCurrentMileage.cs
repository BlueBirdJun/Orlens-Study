using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserCurrentMileage
    {
        public string Userid { get; set; }
        public decimal Currentmileage { get; set; }
        public decimal Jumunmileage { get; set; }
        public decimal Bonusmileage { get; set; }
        public decimal Spendmileage { get; set; }
        public DateTime Lastupdate { get; set; }
        public decimal Flowerjumunmileage { get; set; }
        public decimal? Academymileage { get; set; }
        public decimal? ExpiredMile { get; set; }
        public decimal? Michulmile { get; set; }
        public decimal? MichulmileAca { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserMonthlypay
    {
        public string Empno { get; set; }
        public string Yyyymm { get; set; }
        public int Ino { get; set; }
        public int Worktime { get; set; }
        public int Extendtime { get; set; }
        public int Nighttime { get; set; }
        public int Holidaytime { get; set; }
        public int Wholidaytime { get; set; }
        public int Foodtime { get; set; }
        public decimal Timepay { get; set; }
        public decimal Extendpay { get; set; }
        public decimal Nightpay { get; set; }
        public decimal Holidaypay { get; set; }
        public decimal Foodpay { get; set; }
        public decimal Jobpay { get; set; }
        public decimal Outstandingpay { get; set; }
        public decimal Longtimepay { get; set; }
        public decimal Totpay { get; set; }
        public decimal Npensionpay { get; set; }
        public decimal Healthinspay { get; set; }
        public decimal Recuinspay { get; set; }
        public decimal Unempinspay { get; set; }
        public decimal Taxtotpay { get; set; }
        public decimal Realtotpay { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Adminid { get; set; }
        public byte Paystate { get; set; }
        public decimal Addpay { get; set; }
        public decimal Yearpay { get; set; }
        public decimal Bonuspay { get; set; }
        public int? Workday { get; set; }
        public int? Recaltime { get; set; }
        public decimal? Recalpay { get; set; }
        public int? Recalexttime { get; set; }
        public int? Recalnttime { get; set; }
        public int? Recalhdtime { get; set; }
        public int? Recalftime { get; set; }
        public decimal? Recalexpay { get; set; }
        public decimal? Recalntpay { get; set; }
        public decimal? Recalhdpay { get; set; }
        public decimal? Recalfpay { get; set; }
        public decimal? Recaltotpay { get; set; }
        public int? Recalworkday { get; set; }
    }
}

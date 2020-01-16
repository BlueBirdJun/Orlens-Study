using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserDailypay
    {
        public string Empno { get; set; }
        public string Yyyymmdd { get; set; }
        public int Startwork { get; set; }
        public int Endwork { get; set; }
        public int BreaktimeS { get; set; }
        public int BreaktimeE { get; set; }
        public byte WorkType { get; set; }
        public byte Paystate { get; set; }
        public DateTime Regdate { get; set; }
        public int? Defaulttime { get; set; }
        public int? Extendtime { get; set; }
        public int? Nighttime { get; set; }
        public int? Holidaytime { get; set; }
        public int? Wholidaytime { get; set; }
        public string Adminid { get; set; }
        public int Outtime { get; set; }
        public int? Vacationtime { get; set; }
        public string Procyyyymm { get; set; }
        public int Payidx { get; set; }
    }
}

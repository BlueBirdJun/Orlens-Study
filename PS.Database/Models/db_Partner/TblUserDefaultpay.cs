using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserDefaultpay
    {
        public int Defaultpayseq { get; set; }
        public string Empno { get; set; }
        public int Ino { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Defaultpay { get; set; }
        public decimal Foodpay { get; set; }
        public decimal Jobpay { get; set; }
        public bool InBreakTime { get; set; }
        public int OverTime { get; set; }
        public int SunStart { get; set; }
        public int SunEnd { get; set; }
        public int SunBreakS { get; set; }
        public int SunBreakE { get; set; }
        public int MonStart { get; set; }
        public int MonEnd { get; set; }
        public int MonBreakS { get; set; }
        public int MonBreakE { get; set; }
        public int TueStart { get; set; }
        public int TueEnd { get; set; }
        public int TueBreakS { get; set; }
        public int TueBreakE { get; set; }
        public int WedStart { get; set; }
        public int WedEnd { get; set; }
        public int WedBreakS { get; set; }
        public int WedBreakE { get; set; }
        public int ThuStart { get; set; }
        public int ThuEnd { get; set; }
        public int ThuBreakS { get; set; }
        public int ThuBreakE { get; set; }
        public int FriStart { get; set; }
        public int FriEnd { get; set; }
        public int FriBreakS { get; set; }
        public int FriBreakE { get; set; }
        public int SatStart { get; set; }
        public int SatEnd { get; set; }
        public int SatBreakS { get; set; }
        public int SatBreakE { get; set; }
        public int? Holidaywd { get; set; }
        public int? Holidaywdtime { get; set; }
        public decimal TotPaySum { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Adminid { get; set; }
        public bool? Isusing { get; set; }
        public byte? SunWorkType { get; set; }
        public byte? MonWorkType { get; set; }
        public byte? TueWorkType { get; set; }
        public byte? WedWorkType { get; set; }
        public byte? ThuWorkType { get; set; }
        public byte? FriWorkType { get; set; }
        public byte? SatWorkType { get; set; }
        public int? PositSn { get; set; }
        public int? DepartmentId { get; set; }
        public string PositName { get; set; }
        public string DepartmentFullName { get; set; }
        public byte Jobkind { get; set; }
        public byte Placekind { get; set; }
    }
}

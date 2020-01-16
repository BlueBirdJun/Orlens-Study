using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblTenAgitBooking
    {
        public int Idx { get; set; }
        public byte AreaDiv { get; set; }
        public DateTime ChkStart { get; set; }
        public DateTime ChkEnd { get; set; }
        public int? PartSn { get; set; }
        public int? PositSn { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public string UserPhone { get; set; }
        public string UserHp { get; set; }
        public int UsePersonNo { get; set; }
        public string EtcComment { get; set; }
        public string StatDiv { get; set; }
        public string IsUsing { get; set; }
        public DateTime Regdate { get; set; }
        public int? DepartmentId { get; set; }
        public string Empno { get; set; }
        public decimal? UseMoney { get; set; }
        public byte? Isipkum { get; set; }
        public bool IsreturnKey { get; set; }
        public int? UsePoint { get; set; }
        public DateTime? Refunddate { get; set; }
        public DateTime? Canceldate { get; set; }
        public DateTime? Ipkumdate { get; set; }
        public string Adminid { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

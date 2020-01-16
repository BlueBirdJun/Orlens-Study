using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserTenbyten
    {
        public string Empno { get; set; }
        public string Userid { get; set; }
        public string Frontid { get; set; }
        public string Username { get; set; }
        public string Juminno { get; set; }
        public DateTime? Birthday { get; set; }
        public string Issolar { get; set; }
        public string Sexflag { get; set; }
        public string Zipcode { get; set; }
        public string Zipaddr { get; set; }
        public string Useraddr { get; set; }
        public string Userphone { get; set; }
        public string Usercell { get; set; }
        public string Usermail { get; set; }
        public string Msnmail { get; set; }
        public string Interphoneno { get; set; }
        public string Extension { get; set; }
        public string Direct070 { get; set; }
        public string Jobdetail { get; set; }
        public string Statediv { get; set; }
        public DateTime? Joinday { get; set; }
        public DateTime? Realjoinday { get; set; }
        public DateTime? Retireday { get; set; }
        public byte? Retirereason { get; set; }
        public string Userimage { get; set; }
        public string Mywork { get; set; }
        public DateTime? Regdate { get; set; }
        public int? PartSn { get; set; }
        public int? PositSn { get; set; }
        public int? JobSn { get; set; }
        public bool? Isusing { get; set; }
        public string IsIdentify { get; set; }
        public string BizsectionCd { get; set; }
        public string Emppass { get; set; }
        public string Messenger { get; set; }
        public string EncEmppass { get; set; }
        public int? Criticinfouser { get; set; }
        public int? DepartmentId { get; set; }
        public short? RankSn { get; set; }
        public string Personalmail { get; set; }
    }
}

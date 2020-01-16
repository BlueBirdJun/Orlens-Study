using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerTempInfo
    {
        public int Tidx { get; set; }
        public string Gubun { get; set; }
        public string Reguserid { get; set; }
        public string Groupid { get; set; }
        public string GroupidOld { get; set; }
        public string CompanyName { get; set; }
        public string Ceoname { get; set; }
        public string CompanyNo { get; set; }
        public string JungsanGubun { get; set; }
        public string CompanyZipcode { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyUptae { get; set; }
        public string CompanyUpjong { get; set; }
        public string CompanyTel { get; set; }
        public string CompanyFax { get; set; }
        public string ReturnZipcode { get; set; }
        public string ReturnAddress { get; set; }
        public string ReturnAddress2 { get; set; }
        public string JungsanBank { get; set; }
        public string JungsanAcctno { get; set; }
        public string JungsanAcctname { get; set; }
        public string JungsanDate { get; set; }
        public string JungsanDateOff { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPhone { get; set; }
        public string ManagerHp { get; set; }
        public string ManagerEmail { get; set; }
        public string JungsanName { get; set; }
        public string JungsanPhone { get; set; }
        public string JungsanHp { get; set; }
        public string JungsanEmail { get; set; }
        public byte Status { get; set; }
        public string Comment { get; set; }
        public string Confirmuserid { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public byte[] EncCompNo { get; set; }
    }
}

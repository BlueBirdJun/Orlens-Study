using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartner
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public decimal? Discountrate { get; set; }
        public string CompanyName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Bigo { get; set; }
        public string Url { get; set; }
        public string ManagerName { get; set; }
        public string ManagerAddress { get; set; }
        public double? Commission { get; set; }
        public string Email { get; set; }
        public string Msn { get; set; }
        public int? Userdiv { get; set; }
        public string Isusing { get; set; }
        public DateTime Regdate { get; set; }
        public string CompanyNo { get; set; }
        public string Zipcode { get; set; }
        public string Ceoname { get; set; }
        public string ManagerPhone { get; set; }
        public string ManagerHp { get; set; }
        public string DeliverName { get; set; }
        public string DeliverPhone { get; set; }
        public string DeliverHp { get; set; }
        public string DeliverEmail { get; set; }
        public string JungsanName { get; set; }
        public string JungsanPhone { get; set; }
        public string JungsanHp { get; set; }
        public string JungsanEmail { get; set; }
        public string JungsanGubun { get; set; }
        public string JungsanBank { get; set; }
        public string JungsanDate { get; set; }
        public string JungsanAcctname { get; set; }
        public string JungsanAcctno { get; set; }
        public string CompanyUpjong { get; set; }
        public string CompanyUptae { get; set; }
        public string Groupid { get; set; }
        public string Subid { get; set; }
        public double? Onlinedefaultmargin { get; set; }
        public string Onlinemwdiv { get; set; }
        public double? Offlinedefaultmargin { get; set; }
        public string Offlinejungsangubun { get; set; }
        public double? Frandefaultmargin { get; set; }
        public string Franjungsangubun { get; set; }
        public string Lastip { get; set; }
        public string Buseo { get; set; }
        public string Part { get; set; }
        public string Cposition { get; set; }
        public string Userimg { get; set; }
        public string Intro { get; set; }
        public string ReturnZipcode { get; set; }
        public string ReturnAddress { get; set; }
        public string ReturnAddress2 { get; set; }
        public string JungsanDateOff { get; set; }
        public string JungsanDateFrn { get; set; }
        public int? Defaultsongjangdiv { get; set; }
        public int? PartSn { get; set; }
        public int? PositSn { get; set; }
        public int? LevelSn { get; set; }
        public string BirthIsSolar { get; set; }
        public double? MMargin { get; set; }
        public double? WMargin { get; set; }
        public double? UMargin { get; set; }
        public int? JobSn { get; set; }
        public int PurchaseType { get; set; }
        public string Offcatecode { get; set; }
        public string Offmduserid { get; set; }
        public int PartnerSeq { get; set; }
        public int? SellType { get; set; }
        public string SellBizCd { get; set; }
        public int? Taxevaltype { get; set; }
        public string Etcjungsantype { get; set; }
        public string Tplcompanyid { get; set; }
        public string EncPassword { get; set; }
        public DateTime? LastLoginDt { get; set; }
        public DateTime? LastPwChgDt { get; set; }
        public DateTime? LastExpireDt { get; set; }
        public string EncPassword64 { get; set; }
        public DateTime? LastInfoChgDt { get; set; }
        public string Enc2password64 { get; set; }
        public string Lastadminid { get; set; }
        public byte? Signtype { get; set; }
    }
}

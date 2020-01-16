using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblVacationDetail
    {
        public int Idx { get; set; }
        public int Masteridx { get; set; }
        public DateTime Startday { get; set; }
        public DateTime Endday { get; set; }
        public double Totalday { get; set; }
        public string Halfgubun { get; set; }
        public string Approverid { get; set; }
        public DateTime? Approveday { get; set; }
        public string Statedivcd { get; set; }
        public string Deleteyn { get; set; }
        public string Registerid { get; set; }
        public DateTime Regdate { get; set; }
        public string Approverempno { get; set; }
        public string Registerempno { get; set; }
        public string WorkAgent { get; set; }
        public string CallNum { get; set; }
    }
}

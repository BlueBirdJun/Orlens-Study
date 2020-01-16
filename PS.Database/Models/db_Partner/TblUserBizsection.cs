using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblUserBizsection
    {
        public int Idx { get; set; }
        public string Empno { get; set; }
        public string Yyyymm { get; set; }
        public string BizsectionCd { get; set; }
        public int Persent { get; set; }
        public DateTime Regdate { get; set; }
        public string Adminid { get; set; }
        public string BizsectionUseCd { get; set; }
    }
}

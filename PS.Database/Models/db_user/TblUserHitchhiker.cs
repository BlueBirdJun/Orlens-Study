using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class TblUserHitchhiker
    {
        public int Idx { get; set; }
        public int Hvol { get; set; }
        public string Userid { get; set; }
        public short ApplyVol { get; set; }
        public DateTime ApplyDate { get; set; }
        public short? SendVol { get; set; }
        public DateTime? SendDate { get; set; }
        public string RecevieName { get; set; }
        public string Zipcode { get; set; }
        public string Useraddr { get; set; }
        public string Userphone { get; set; }
        public string Usercell { get; set; }
        public string AdminId { get; set; }
        public string Zipaddr { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblGiftcardItem
    {
        public int Carditemid { get; set; }
        public string Carditemname { get; set; }
        public string Cardinfo { get; set; }
        public string Carddesc { get; set; }
        public string Cardsellyn { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Reguserid { get; set; }
        public DateTime Regdate { get; set; }
        public string Basicimage { get; set; }
        public string Basicimage600 { get; set; }
        public string Smallimage { get; set; }
        public string Listimage { get; set; }
        public string Listimage120 { get; set; }
        public string Icon1Image { get; set; }
        public string Icon2Image { get; set; }
    }
}

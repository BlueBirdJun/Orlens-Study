using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppPayDoc
    {
        public int Paydocidx { get; set; }
        public int PayRequestIdx { get; set; }
        public byte Paydockind { get; set; }
        public string Vatkind { get; set; }
        public DateTime? Issuedate { get; set; }
        public string Itemname { get; set; }
        public decimal? Totprice { get; set; }
        public decimal? Supplyprice { get; set; }
        public decimal? Vatprice { get; set; }
        public string Etaxkey { get; set; }
        public string Bigo { get; set; }
        public string Attachfile { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string AdminId { get; set; }
        public DateTime? ErpDocSendDate { get; set; }
        public string ErpDocLinkType { get; set; }
        public string ErpDocLinkKey { get; set; }
    }
}

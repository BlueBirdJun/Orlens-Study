using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateDocument
    {
        public int DocIdx { get; set; }
        public string Id { get; set; }
        public DateTime? DocStartdate { get; set; }
        public DateTime? DocEnddate { get; set; }
        public byte DocType { get; set; }
        public byte DocImportant { get; set; }
        public byte DocDifficult { get; set; }
        public string DocSubject { get; set; }
        public string DocContent { get; set; }
        public byte DocStatus { get; set; }
        public DateTime DocRegdate { get; set; }
        public string DocUseyn { get; set; }
        public string DocAnsOx { get; set; }
        public string DocWorkername { get; set; }
        public string DocRefername { get; set; }
    }
}

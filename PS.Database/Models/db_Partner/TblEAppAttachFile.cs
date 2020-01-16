using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEAppAttachFile
    {
        public int AttachFileIdx { get; set; }
        public int ReportIdx { get; set; }
        public int PayRequestIdx { get; set; }
        public string Filelink { get; set; }
        public byte? FileType { get; set; }
    }
}

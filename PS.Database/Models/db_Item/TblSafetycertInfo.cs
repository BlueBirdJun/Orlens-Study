using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblSafetycertInfo
    {
        public int Infoidx { get; set; }
        public int Itemid { get; set; }
        public string CertUid { get; set; }
        public string CertOrganName { get; set; }
        public string CertNum { get; set; }
        public string CertState { get; set; }
        public string CertDiv { get; set; }
        public string CertDate { get; set; }
        public string CertChgDate { get; set; }
        public string CertChgReason { get; set; }
        public string FirstCertNum { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string CategoryName { get; set; }
        public string ImportDiv { get; set; }
        public string MakerName { get; set; }
        public string MakerCntryName { get; set; }
        public string ImporterName { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

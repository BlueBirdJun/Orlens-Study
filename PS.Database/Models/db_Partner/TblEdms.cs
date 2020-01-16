using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEdms
    {
        public int Edmsidx { get; set; }
        public int Cateidx1 { get; set; }
        public int Cateidx2 { get; set; }
        public string SerialNum { get; set; }
        public string Edmsname { get; set; }
        public string Edmscode { get; set; }
        public int? ViewNo { get; set; }
        public string EdmsFile { get; set; }
        public bool? IsApproval { get; set; }
        public bool? IsScmApproval { get; set; }
        public byte? LastApprovalid { get; set; }
        public string ScmLink { get; set; }
        public string ScmSubmitLink { get; set; }
        public DateTime Regdate { get; set; }
        public bool? IsUsing { get; set; }
        public string Adminid { get; set; }
        public bool IsPayEapp { get; set; }
        public string Edmsform { get; set; }
        public bool CfoAgree { get; set; }
        public string IsAgreeNeed { get; set; }
        public string IsAgreeNeedTarget { get; set; }
    }
}

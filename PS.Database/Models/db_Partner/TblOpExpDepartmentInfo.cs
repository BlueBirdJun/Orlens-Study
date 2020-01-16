using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblOpExpDepartmentInfo
    {
        public int Idx { get; set; }
        public int OpExpPartIdx { get; set; }
        public int DepartmentId { get; set; }
        public string UseYn { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}

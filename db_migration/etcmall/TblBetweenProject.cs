using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblBetweenProject
    {
        public int PjtCode { get; set; }
        public string PjtName { get; set; }
        public string PjtKind { get; set; }
        public string PjtTopImgUrl { get; set; }
        public string PjtGender { get; set; }
        public byte PjtState { get; set; }
        public DateTime PjtRegdate { get; set; }
        public string PjtUsing { get; set; }
        public DateTime PjtLastupdate { get; set; }
        public string PjtSortType { get; set; }
        public string Adminid { get; set; }
    }
}

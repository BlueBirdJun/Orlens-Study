using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblCooperateAns
    {
        public int AnsIdx { get; set; }
        public int DocIdx { get; set; }
        public string Id { get; set; }
        public byte AnsType { get; set; }
        public string AnsContent { get; set; }
        public DateTime AnsRegdate { get; set; }
        public string AnsUseyn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPhotoUser
    {
        public int UserNo { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int? UserType { get; set; }
        public DateTime? UserRegdate { get; set; }
        public string UserUseyn { get; set; }
    }
}

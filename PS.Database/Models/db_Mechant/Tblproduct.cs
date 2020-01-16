using PS.Database.Models.db_Item;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblproduct
    {
        public int Productkey { get; set; }
        public string Productname { get; set; }
        public string Productattribute { get; set; }
        public string Productkind { get; set; }
        public string Saleyn { get; set; }
        public string Useyn { get; set; }
        public string Buydlv { get; set; }
        public string Taxyn { get; set; }
        public string Productcode { get; set; }
        public int Brandkey { get; set; }
        public int Categorykey { get; set; }
        public DateTime Createdate { get; set; }

        [NotMapped]
        public int tenitemid { get; set; }
        [NotMapped]
        public Tblprice ProductPrice { get; set; }

        [NotMapped]
        public TblItem TenItem { get; set; }

    } 

}

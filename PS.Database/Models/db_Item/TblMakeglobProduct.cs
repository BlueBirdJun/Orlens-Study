using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblMakeglobProduct
    {
        public int ProductKey { get; set; }
        public int ProductCode { get; set; }
        public string ProductLanguage { get; set; }
        public string Currency { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SupplyPrice { get; set; }
        public string ListImgUrl { get; set; }
        public string DetailImgUrl { get; set; }
        public string ZoomImgUrl { get; set; }
        public string Basic600ImgUrl { get; set; }
        public string Basic1000ImgUrl { get; set; }
        public double Mileage { get; set; }
        public double Weight { get; set; }
        public string MakerName { get; set; }
        public string Madein { get; set; }
        public string BrandName { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? LaunchingDate { get; set; }
        public string Keyword { get; set; }
        public string Desc { get; set; }
        public string Itemsource { get; set; }
        public string Itemsize { get; set; }
        public string Hidden { get; set; }
        public string Soldout { get; set; }
        public string ProductUrl { get; set; }
        public int? PdtStock { get; set; }
        public string Cateindex { get; set; }
        public string MakeglobYn { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public DateTime? Makeupdate { get; set; }
    }
}

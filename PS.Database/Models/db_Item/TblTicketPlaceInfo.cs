using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblTicketPlaceInfo
    {
        public int TicketPlaceIdx { get; set; }
        public string TicketPlaceName { get; set; }
        public string TPaddress { get; set; }
        public string TPtel { get; set; }
        public string TPhomeUrl { get; set; }
        public string PlaceLinkUrl { get; set; }
        public string PlaceImgUrl { get; set; }
        public string PlacecontentsImage1 { get; set; }
        public string PlacecontentsImage2 { get; set; }
        public string PlacecontentsImage3 { get; set; }
        public string PlaceContents { get; set; }
        public string ParkingGuide { get; set; }
    }
}

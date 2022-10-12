using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs
{
    public class BidSearchDTO
    {
        public string BidName { get; set; }
        public int UserTypeID { get; set; }
        public List<SelectListItem> UserType { get; set; }
        public int StatusID { get; set; }
        public List<SelectListItem> Status { get; set; }
    }
}

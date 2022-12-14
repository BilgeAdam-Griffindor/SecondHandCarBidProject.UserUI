using SecondHandCarBidProject.UserUI.Dto.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Models
{
    public class BidAddModel
    {
        public string BidName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Guid> CarIds { get; set; }
        public List<SelectListItem> CarList { get; set; }
    }
}
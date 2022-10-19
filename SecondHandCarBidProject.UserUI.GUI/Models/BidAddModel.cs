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
        public bool IsCorporate { get; set; }
        public int? CorporationId { get; set; }
        public int StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Guid> CarIds { get; set; }
        public List<SelectListItem> CorporationList { get; set; }
        public List<SelectListItem> StatusList { get; set; }
        public List<SelectListItem> CarList { get; set; }
    }
}
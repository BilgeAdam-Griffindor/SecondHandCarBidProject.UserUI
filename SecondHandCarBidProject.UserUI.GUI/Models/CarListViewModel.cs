using SecondHandCarBidProject.UserUI.Dto.CarDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Models
{
    public class CarListViewModel
    {
        public int? BrandId { get; set; }
        public List<SelectListItem> BrandList { get; set; }
        public int? ModelId { get; set; }
        public List<SelectListItem> ModelList { get; set; }
        public int? StatusId { get; set; }
        public List<SelectListItem> StatusList { get; set; }
        public List<CarListTableRowDTO> TableRows { get; set; }
        public int Page { get; set; }
        public int ItemPerPage { get; set; }
    };
}
using SecondHandCarBidProject.UserUI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CarDetailInformation()
        {
            CarDetailDto carDetailDto = new CarDetailDto();
            carDetailDto.selectItemList = new List<SelectListItem> { new SelectListItem { Text = "Bireysel", Value = "1" }, new SelectListItem { Text = "Kurumsal", Value = "2" } };
            
            return View(carDetailDto);
        }
        [HttpPost]
        public ActionResult CarDetailInformation(string deneme)
        {
            return View();
        }
    }
}
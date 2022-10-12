using SecondHandCarBidProject.UserUI.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class CarBuyController : Controller
    {
        // GET: CarBuy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            CarBuyAddViewModel carBuyAddViewModel = new CarBuyAddViewModel();
            carBuyAddViewModel.BodyTypeList = new List<SelectListItem>();
            carBuyAddViewModel.BrandList = new List<SelectListItem>();
            carBuyAddViewModel.ColorList = new List<SelectListItem>();
            carBuyAddViewModel.ModelList = new List<SelectListItem>();
            carBuyAddViewModel.VersionList = new List<SelectListItem>();
            carBuyAddViewModel.OptionalHardwareList = new List<SelectListItem>();
            carBuyAddViewModel.FuelTypeList = new List<SelectListItem>();
            carBuyAddViewModel.GearTypeList = new List<SelectListItem>();

            return View(carBuyAddViewModel);
        }

        [HttpPost]
        public ActionResult Add(CarBuyAddViewModel viewData)
        {
            return View();
        }
    }
}
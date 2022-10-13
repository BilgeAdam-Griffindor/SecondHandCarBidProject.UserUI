using SecondHandCarBidProject.UserUI.Dto.DTOs;
using SecondHandCarBidProject.UserUI.GUI.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class CorporationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddCorporation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCorporation(CorporationAddViewModels corporationAddViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateCorporation(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateCorporation(CorporationUpdateViewModels corporationUpdateViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult RemoveCorporation(int Id)
        {
            return View();
        }
    }
}
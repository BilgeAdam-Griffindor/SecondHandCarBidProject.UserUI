using SecondHandCarBidProject.UserUI.Dto.DTOs;
using SecondHandCarBidProject.UserUI.GUI.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class ExpertInfoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddExpertInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExpertInfo(ExpertInfoAddViewModels expertInfoAddViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateExpertInfo(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateExpertInfo(ExpertInfoUpdateViewModels expertInfoUpdateView)
        {
            return View();
        }

        [HttpGet]
        public ActionResult RemoveExpertInfo(int Id)
        {
            return View();
        }
    }
}
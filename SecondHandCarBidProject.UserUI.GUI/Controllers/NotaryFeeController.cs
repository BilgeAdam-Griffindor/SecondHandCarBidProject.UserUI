using SecondHandCarBidProject.UserUI.Dto.DTOs;
using SecondHandCarBidProject.UserUI.GUI.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class NotaryFeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddNotaryFee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNotaryFee(NotaryFeeAddViewModels notaryFeeAddViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateNotaryFee(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateNotaryFee(NotaryFeeUpdateViewModels notaryFeeUpdateViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult RemoveNotaryFee(int Id)
        {
            return View();
        }
    }
}
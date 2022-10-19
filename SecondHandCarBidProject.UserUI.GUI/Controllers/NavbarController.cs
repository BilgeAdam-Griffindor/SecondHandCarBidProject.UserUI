using SecondHandCarBidProject.UserUI.Dto.DTOs;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class NavbarController : Controller
    {
        // GET: Bid
        //  BaseApi baseApi = new BaseApi();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}
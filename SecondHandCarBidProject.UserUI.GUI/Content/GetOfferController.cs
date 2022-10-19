using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Content
{
    public class GetOfferController : Controller
    {
        // GET: GetOffer
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}
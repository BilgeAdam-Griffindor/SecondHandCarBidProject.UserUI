using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class BidController : Controller
    {
        // GET: Bid
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BidList()
        {
            ViewBag.Liste = new List<string> { "1", "yeni ihale", "bireysel", "05/10/2022", "07/10/2022", "Bitti", "EmreÇ", "2020/05/10-11.00" };
            return View();
        }
    }
}
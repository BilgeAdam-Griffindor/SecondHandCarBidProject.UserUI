using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
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
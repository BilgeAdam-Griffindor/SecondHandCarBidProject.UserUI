using SecondHandCarBidProject.UserUI.Dto.DTOs;
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
        [HttpGet]
        public ActionResult BidList()
        {
            ViewBag.Liste = new List<string> { "1", "yeni ihale", "bireysel", "05/10/2022", "07/10/2022", "Bitti", "EmreÇ", "2020/05/10-11.00" };
            BidListDTO bidListDTO = new BidListDTO()
            {
                Status = new List<SelectListItem> { new SelectListItem { Text = "Başlamadı", Value = "1" }, new SelectListItem { Text = "Başladı", Value = "2" }, new SelectListItem { Text = "Bitti", Value = "3" }, new SelectListItem { Text = "İptal", Value = "4" } },
                UserType = new List<SelectListItem> { new SelectListItem { Text = "Bireysel", Value = "1" }, new SelectListItem { Text = "Kurumsal", Value = "2" } }
            };

            return View(bidListDTO);
        }
        [HttpPost]
        public ActionResult BidList(BidListDTO bidListDTO)
        {
            return View();
        }
    }
}
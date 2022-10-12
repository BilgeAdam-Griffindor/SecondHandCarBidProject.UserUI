using SecondHandCarBidProject.UserUI.Dto.DTOs;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class BidController : Controller
    {
        // GET: Bid
        //  BaseApi baseApi = new BaseApi();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult BidList()
        {
            //  var bid = await baseApi.GetByFilterAsync<BidDTO>("api adres", "token", "");
            ViewBag.Liste = new List<BidDTO> { new BidDTO { BidID = 1, BidName = "yeni ihale", BidUserType = "bireysel", BidStartDate = System.DateTime.Now, BidEndDate = System.DateTime.Now, Statu = "Bitti", User = "EmreÇ", BidCreatedDate = "2020/05/10-11.00" } };

            BidSearchDTO bidListDTO = new BidSearchDTO()
            {
                Status = new List<SelectListItem> { new SelectListItem { Text = "Başlamadı", Value = "1" }, new SelectListItem { Text = "Başladı", Value = "2" }, new SelectListItem { Text = "Bitti", Value = "3" }, new SelectListItem { Text = "İptal", Value = "4" } },
                UserType = new List<SelectListItem> { new SelectListItem { Text = "Bireysel", Value = "1" }, new SelectListItem { Text = "Kurumsal", Value = "2" } }
            };

            return View(bidListDTO);
        }
        [HttpPost]
        public ActionResult BidList(BidSearchDTO bidListDTO)
        {
            return View();
        }
    }
}
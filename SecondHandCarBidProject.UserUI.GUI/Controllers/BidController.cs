using SecondHandCarBidProject.UserUI.Dto.DTOs;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface;
using SecondHandCarBidProject.UserUI.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class BidController : Controller
    {
        IBaseApi _baseApi;
        public BidController()
        {
            _baseApi = new BaseApi();
        }

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

        [HttpGet]
        public async Task<ActionResult> Add()
        {
            try
            {
                string isCorp = "false";
                if (Session["userCorporationId"] != null)
                    isCorp = "true";

                var query = "userId=" + Session["currentUserId"].ToString() + "&isCorporate=" + isCorp;
                ResponseModel<BidAddPageUserDTO> responseModel = await _baseApi.GetByFilterAsync<ResponseModel<BidAddPageUserDTO>>("Bid/AddGetUser", Session["userToken"].ToString());

                if (responseModel != null && responseModel.IsSuccess)
                {
                    BidAddModel bidAddModel = new BidAddModel()
                    {
                        CarList = responseModel.Data.CarList.Select(x => new SelectListItem()
                        {
                            Value = x.Id.ToString(),
                            Text = x.Name
                        }).ToList()
                    };

                    return View(bidAddModel);
                }
                else
                {
                    return RedirectToAction("Index", "Error");
                }

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [ValidateAntiForgeryToken]
        //[Authorize]
        [HttpPost]
        public async Task<ActionResult> Add(BidAddModel model)
        {
            try
            {
                int? corpId = null;
                if (Session["userCorporationId"] != null)
                    corpId = Convert.ToInt32(Session["userCorporationId"]);

                BidAddSendUserDTO sendDTO = new BidAddSendUserDTO()
                {
                    BidName = model.BidName,
                    CorporationId = corpId,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    CarIds = model.CarIds,
                    CreatedBy = new Guid(Session["currentUserId"].ToString())
                };

                ResponseModel<bool> responseModel = await _baseApi.PostAsync<ResponseModel<bool>, BidAddSendUserDTO>("Bid/AddPostUser", sendDTO, "token");

                if (responseModel.IsSuccess)
                {
                    return RedirectToAction("Add");
                }
                else
                {
                    return RedirectToAction("Index", "Error");
                }

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}
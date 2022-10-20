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
                //ResponseModel<BidAddPageDTO> responseModel = await _baseApi.GetByFilterAsync<ResponseModel<BidAddPageDTO>>("Bid/Add", Session["userToken"].ToString());

                ResponseModel<BidAddPageDTO> responseModel = new ResponseModel<BidAddPageDTO>();
                responseModel.IsSuccess = true;

                if (responseModel.IsSuccess)
                {
                    //BidAddModel bidAddModel = new BidAddModel()
                    //{
                    //    CorporationList = responseModel.Data.CorporationList.Select(x => new SelectListItem()
                    //    {
                    //        Value = x.Id.ToString(),
                    //        Text = x.Name
                    //    }).ToList(),
                    //    StatusList = responseModel.Data.StatusList.Select(x => new SelectListItem()
                    //    {
                    //        Value = x.Id.ToString(),
                    //        Text = x.Name
                    //    }).ToList(),
                    //    CarList = responseModel.Data.CarList.Select(x => new SelectListItem()
                    //    {
                    //        Value = x.Id.ToString(),
                    //        Text = x.Name
                    //    }).ToList()
                    //};

                    BidAddModel bidAddModel = new BidAddModel()
                    {
                        CorporationList = new List<SelectListItem>()
                        {
                            new SelectListItem()
                            {
                                Value="23",
                                Text = "Corp 1"
                            },
                            new SelectListItem()
                            {
                                Value="2343",
                                Text = "Corp 2"
                            },
                            new SelectListItem()
                            {
                                Value="2353",
                                Text = "Corp 3"
                            }
                        },
                        StatusList = new List<SelectListItem>()
                        {
                            new SelectListItem()
                            {
                                Value="23",
                                Text = "Stat 1"
                            },
                            new SelectListItem()
                            {
                                Value="2343",
                                Text = "Stat 2"
                            },
                            new SelectListItem()
                            {
                                Value="2353",
                                Text = "Stat 3"
                            }
                        },
                        CarList = new List<SelectListItem>()
                        {
                            new SelectListItem()
                            {
                                Value= Guid.NewGuid().ToString(),
                                Text = "Car 1"
                            },
                            new SelectListItem()
                            {
                                Value=Guid.NewGuid().ToString(),
                                Text = "Car 2"
                            },
                            new SelectListItem()
                            {
                                Value=Guid.NewGuid().ToString(),
                                Text = "Car 3"
                            }
                        }
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
                BidAddSendDTO sendDTO = new BidAddSendDTO()
                {
                    BidName = model.BidName,
                    IsCorporate = model.IsCorporate,
                    CorporationId = model.CorporationId,
                    StatusId = model.StatusId,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    CarIds = model.CarIds
                };

                ResponseModel<bool> responseModel = await _baseApi.PostAsync<ResponseModel<bool>, BidAddSendDTO>("Bid/Add", sendDTO, Session["userToken"].ToString());

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
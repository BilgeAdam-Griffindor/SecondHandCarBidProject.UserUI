using SecondHandCarBidProject.UserUI.Dto;
using SecondHandCarBidProject.UserUI.Dto.CarDtos;
using SecondHandCarBidProject.UserUI.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class CarController : Controller
    {
        [HttpGet]
        [ValidateAntiForgeryToken]
        public ActionResult Index()
        {
            CarListViewModel model = new CarListViewModel();
            model.BrandList = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Boş",
                    Value = null
                },
                new SelectListItem()
                {
                    Text = "Brand 1",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "Brand 2",
                    Value = "2"
                },
                new SelectListItem()
                {
                    Text = "Brand 3",
                    Value = "3"
                }
            };
            model.ModelList = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Boş",
                    Value = null
                },
                new SelectListItem()
                {
                    Text = "Model 1",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "Model 2",
                    Value = "2"
                }
            };
            model.StatusList = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Boş",
                    Value = null
                },
                new SelectListItem()
                {
                    Text = "Status 1",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "Status 2",
                    Value = "2"
                }
            };
            model.TableRows = new List<CarListTableRowDTO>()
            {
                new CarListTableRowDTO()
                {
                    CarId = Guid.NewGuid(),
                    BrandName = "Test Brand",
                    ModelName = "Test Model",
                    IndividualOrCorporate = "Bireysel",
                    RegisterDate = DateTime.Now,
                    Status = "Test Status",
                    Username = "Test User Name"
                },
                new CarListTableRowDTO()
                {
                    CarId = Guid.NewGuid(),
                    BrandName = "Test Brand 2",
                    ModelName = "Test Model 2",
                    IndividualOrCorporate = "Bireysel",
                    RegisterDate = DateTime.Now,
                    Status = "Test Status 2",
                    Username = "Test User Name 2"
                }
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CarListViewModel viewData)
        {

            return View();
        }

        [HttpGet]
        public ActionResult CarDetailInformation()
        {
            CarDetailDto carDetailDto = new CarDetailDto();
            carDetailDto.selectItemList = new List<SelectListItem> { new SelectListItem { Text = "Bireysel", Value = "1" }, new SelectListItem { Text = "Kurumsal", Value = "2" } };
            
            return View(carDetailDto);
        }
        [HttpPost]
        public ActionResult CarDetailInformation(CarDetailDto dto)
        {
            return View();
        }
    }
}
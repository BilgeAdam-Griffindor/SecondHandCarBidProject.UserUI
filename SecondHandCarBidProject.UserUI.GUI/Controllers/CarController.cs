using SecondHandCarBidProject.Logging.Concrete;
using SecondHandCarBidProject.Logging.LogModels;
using SecondHandCarBidProject.UserUI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> CarDetailInformation()
        {
            //Logger Deneme
            //LoggerFactoryMethod log = new LoggerFactoryMethod();
            //LogModel logModel = new LogModel();
            //logModel.CreatedDate = DateTime.Now;
            //logModel.Exception = "asdasdafa";
            //logModel.LogType = "asfasda";
            //await log.FactoryMethod(LoggerFactoryMethod.LoggerType.FileLogger, logModel);
            CarDetailDto carDetailDto = new CarDetailDto();
            carDetailDto.selectItemList = new List<SelectListItem> { new SelectListItem { Text = "Bireysel", Value = "1" }, new SelectListItem { Text = "Kurumsal", Value = "2" } };
            
            return View(carDetailDto);
        }
        [HttpPost]
        public ActionResult CarDetailInformation(string deneme)
        {
            return View();
        }
    }
}
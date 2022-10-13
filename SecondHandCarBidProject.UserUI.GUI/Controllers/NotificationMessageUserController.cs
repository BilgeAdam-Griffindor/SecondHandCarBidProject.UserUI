using SecondHandCarBidProject.UserUI.Dto.DTOs;
using SecondHandCarBidProject.UserUI.GUI.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class NotificationMessageUserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddNotificationMessageUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNotificationMessageUser(NotificationMessageUserAddViewModels notificationMessageUserAddViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateNotificationMessageUser(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateNotificationMessageUser(NotificationMessageUserUpdateViewModels notificationMessageUserUpdateViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult RemoveNotificationMessageUser(int Id)
        {
            return View();
        }
    }
}
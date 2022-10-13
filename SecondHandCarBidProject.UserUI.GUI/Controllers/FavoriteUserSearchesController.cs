using SecondHandCarBidProject.UserUI.Dto.DTOs;
using SecondHandCarBidProject.UserUI.GUI.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class FavoriteUserSearchesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddFavoriteUserSearches()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFavoriteUserSearches(FavoriteUserSearchesAddViewModels favoriteUserSearchesAddViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateFavoriteUserSearches(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateFavoriteUserSearches(FavoriteUserSearchesUpdateViewModels favoriteUserSearchesUpdateViewModels)
        {
            return View();
        }

        [HttpGet]
        public ActionResult RemoveFavoriteUserSearches(int Id)
        {
            return View();
        }
    }
}
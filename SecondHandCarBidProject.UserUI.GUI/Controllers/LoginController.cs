using SecondHandCarBidProject.UserUI.Dto;
using SecondHandCarBidProject.UserUI.Dto.DTOs.UserDtos;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete;
using SecondHandCarBidProject.UserUI.GUI.Extensions;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class LoginController : Controller
    {
        private BaseApi _baseapi;
        // GET: Login
        [HttpGet]
        public ActionResult LogIn()
        {
            return View(new UserLoginDTO());
        }
        [HttpPost]
        public ActionResult LogIn(UserLoginDTO loginData)
        {
            var response = _baseapi.LoginAsync<UserResponseDTO, UserLoginDTO>("Login/GetLogin", loginData);
            HttpContext.Session.Set<ExampleDTO>("user", response.Result.User);
            HttpContext.Session.Set<TokenDTO>("token", response.Result.Token);
            return RedirectToAction("Index", "Default");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterDTO registerData)
        {
            return View();
        }
    }
}
using SecondHandCarBidProject.UserUI.Dto.DTOs.UserDtos;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete;
using SecondHandCarBidProject.UserUI.GUI.Extensions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Controllers
{
    public class LoginController : Controller
    {
        private BaseApi _baseapi = new BaseApi();
        // GET: Login
        [HttpGet]
        public ActionResult LogIn()
        {
            return View(new TokenUserRequestDTO());
        }
        [HttpPost]
        public async Task<ActionResult> LogIn(TokenUserRequestDTO loginData)
        {
            if (loginData == null)
            {
                return View(loginData);
            }
            else
            {
                var response = await _baseapi.LoginAsync<UserResponseDTO, TokenUserRequestDTO>("Login/LoginUser", loginData);
                if (response.Errors == null)
                {
                    HttpContext.Session.Set<BaseUserDTO>("user", response.Data.User);
                    HttpContext.Session.Set<string>("accessToken", response.Data.Token.AccessToken);
                    HttpContext.Session.Set<string>("RefreshToken", response.Data.Token.RefreshToken);
                    return RedirectToAction("Index", "Default");//todo:should go dashboard
                }
                else
                {
                    return View(loginData);
                }
            }

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
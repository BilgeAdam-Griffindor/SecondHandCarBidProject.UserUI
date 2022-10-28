using SecondHandCarBidProject.UserUI.Dto.DTOs.AddressInfoDTOs;
using SecondHandCarBidProject.UserUI.Dto.DTOs.UserDtos;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete;
using SecondHandCarBidProject.UserUI.GUI.Extensions;
using SecondHandCarBidProject.UserUI.GUI.Security;
using System;
using System.Collections.Generic;
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
            if (!ModelState.IsValid)
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
                    ModelState.AddModelError("LoginPassword", response.Errors[0]);
                    return View(loginData);
                }
            }

        }
        [HttpGet]
        public async Task<ActionResult> Register()
        {
            var response = await _baseapi.GetAddressRegisterAsync<List<AddressInfoListDTO>>("Address/GetAddresses");
            BaseUserAddPageDTO baseUser = new BaseUserAddPageDTO();
            foreach (var item in response.Data)
            {
                if (item.AddressTypeId == 1)
                {
                    baseUser.Cities.Add(new SelectListItem()
                    {
                        Text = item.AddressName,
                        Value = item.Id.ToString(),
                    });
                }
                else if (item.AddressTypeId == 2)
                {
                    baseUser.District.Add(new SelectListItem()
                    {
                        Text = item.AddressName,
                        Value = item.Id.ToString()
                    });
                }
            }
            return View(baseUser);
        }
        [HttpPost]
        public async Task<ActionResult> Register(BaseUserAddPageDTO registerData)
        {
            if (!ModelState.IsValid)
            {
                return View(registerData);
            }
            else
            {
                var passwordHash = AESAlgorithm.EncryptToBase64String(registerData.PasswordSalt);
                registerData.CreatedDate = DateTime.Now;
                registerData.ModifiedDate = DateTime.Now;
                registerData.CreatedBy = Guid.Parse("94B4142F-18EB-4E31-B6F5-5FDFEDC8B360");
                registerData.ApprovedBy = Guid.Parse("94B4142F-18EB-4E31-B6F5-5FDFEDC8B360");
                registerData.ModifiedBy = Guid.Parse("94B4142F-18EB-4E31-B6F5-5FDFEDC8B360");
                registerData.IsActive = true;
                registerData.RoleTypeId = 1;
                registerData.EmailVerified = true;
                registerData.IsApproved = false;
                registerData.PasswordHash = passwordHash;

                var response = await _baseapi.RegisterAsync<bool, BaseUserAddPageDTO>("Login/RegisterUser", registerData);
                if (response.Errors == null)
                {
                    return RedirectToAction("LogIn", "Login");//todo:should go dashboard
                }
                else
                {
                    return View(registerData);
                }
            }
        }
    }
}
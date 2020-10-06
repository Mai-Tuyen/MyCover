using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyCover.Model.DTOs.ResponseDTO;
using MyCover.Model.Entities;
using MyCover.Service.IService;

namespace MyCover.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AccountController : ControllerBase
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<LoginResponse> Login([FromBody] User input)
        {
            var res = new LoginResponse();
            try
            {
                var user = await userService.AuthenticateUser(input);
                if (user != null)
                {
                    var tokenString = userService.GenerateJWTToken(user);
                    res.Token = tokenString;
                    res.UserDetails = user;
                }

            }
            catch
            {
                res.IsError = true;
                res.Message = "Đã có lỗi xảy ra trong quá trình xử lý";

            }
            return res;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<LoginResponse> LoginSocial([FromBody] User input)
        {
            var res = new LoginResponse();
            try
            {
                await userService.CheckIsExistSocialAccount(input);
                var tokenString = userService.GenerateJWTToken(input);

                res.Token = tokenString;
                res.UserDetails = input;
            }
            catch
            {
                res.IsError = true;
                res.Message = "Đã có lỗi xảy ra trong quá trình xử lý";
            }
            return res;
        }

        [HttpGet]
        [Authorize(Policy = Policy.User)]
        public IActionResult GetUserData()
        {
            return Ok("This is a response from user method");
        }

        [HttpGet]
        [Authorize(Policy = Policy.Admin)]
        public IActionResult GetAdminData()
        {
            return Ok("This is a response from admin method");
        }
    }
}

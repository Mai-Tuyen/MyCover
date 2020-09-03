using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        public async Task<IActionResult> Login([FromBody] User input)
        {
            try
            {
                IActionResult response = Unauthorized();
                var user = await userService.AuthenticateUser(input);
                if (user != null)
                {
                    var tokenString = userService.GenerateJWTToken(user);
                    response = Ok(new
                    {
                        token = tokenString,
                        userDetails = user,
                    });
                }
                return response;
            }
            catch (Exception e)
            {
                throw;
            }
            
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

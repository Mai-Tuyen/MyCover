using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyCover.Model.Entities;

namespace MyCover.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private List<User> mockUser = new List<User>
        {
            new User {UserName ="maituyen", Password="13456",Role="Admin"},
            new User {UserName ="test", Password="123",Role="User"}
        };
        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] User input)
        {
            return null;
        }
    }
}

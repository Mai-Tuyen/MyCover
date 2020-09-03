using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyCover.Model.Entities;
using MyCover.Service.IRepository;
using MyCover.Service.IService;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyCover.Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IConfiguration configuration;

        public UserService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            this.unitOfWork = unitOfWork;
            this.configuration = configuration;
        }
        public void AddNewUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public async Task<User> AuthenticateUser(User inputUser)
        {
            var user = await unitOfWork.Users.Get(filter: x => x.UserName == inputUser.UserName && x.Password == inputUser.Password);
            return user.SingleOrDefault();
        }

        public async Task<string> GenerateJWTToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim("role", user.Role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
                        issuer: configuration["Jwt: Issuer"],
                        audience: configuration["Jwt: Audience"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: credentials
                        );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<List<User>> getListUser()
        {
            var res = await unitOfWork.Users.Get();
            return res.ToList();
        }

        public Task<User> getUserByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}

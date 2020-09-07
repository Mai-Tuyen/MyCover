using MyCover.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCover.Service.IService
{
    public interface IUserService
    {
        Task<List<User>> GetListUser();
        Task<User> GetUserByID(int id);
        void AddNewUser(User newUser);
        string GenerateJWTToken(User user);
        Task<User> AuthenticateUser(User user);
    }
}

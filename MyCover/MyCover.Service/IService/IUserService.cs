using MyCover.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCover.Service.IService
{
    public interface IUserService
    {
        Task<List<User>> getListUser();
        Task<User> getUserByID(int id);
        void AddNewUser(User newUser);
        Task<string> GenerateJWTToken(User user);
        Task<User> AuthenticateUser(User user);
    }
}

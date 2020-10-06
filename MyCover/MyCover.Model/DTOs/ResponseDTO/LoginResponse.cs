using MyCover.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCover.Model.DTOs.ResponseDTO
{
    public class LoginResponse : BaseResponse
    {
        public string Token { get; set; }
        public User UserDetails { get; set; }
    }
}

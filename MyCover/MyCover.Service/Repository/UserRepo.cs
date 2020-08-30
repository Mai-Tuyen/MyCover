using MyCover.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCover.Service.Repository
{
    public class UserRepo : BaseRepo<User>
    {
        private readonly MyCoverDbContext context;
        public UserRepo(MyCoverDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}

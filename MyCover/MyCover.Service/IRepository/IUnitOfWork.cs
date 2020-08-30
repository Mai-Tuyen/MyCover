using MyCover.Model.Entities;
using MyCover.Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCover.Service.IRepository
{
    public interface IUnitOfWork
    {
        IBaseRepo<User> Users { get; }
        void Save();
    }
}

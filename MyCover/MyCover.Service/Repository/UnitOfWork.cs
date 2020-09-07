using MyCover.Model.Entities;
using MyCover.Service.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCover.Service.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyCoverDbContext _context;
        private BaseRepo<User> _users;
        public UnitOfWork(MyCoverDbContext context)
        {
            _context = context;
        }

        public IBaseRepo<User> Users
        {
            get
            {
                return _users ??= new BaseRepo<User>(_context);
            }
        }
        public async void Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}

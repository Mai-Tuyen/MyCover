using MyCover.Model.Entities;
using MyCover.Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyCover.Service.Repository
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : class
    {
        private readonly MyCoverDbContext context;
        public BaseRepo(MyCoverDbContext context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public TEntity GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

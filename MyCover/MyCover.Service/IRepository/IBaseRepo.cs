using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyCover.Service.IRepository
{
    public interface IBaseRepo<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = ""
            );
        Task<IEnumerable<TEntity>> GetWithRawSql(string query, params object[] parameter);
        Task<TEntity> GetByID(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
    }
}

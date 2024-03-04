using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MotoLog.Business.Entity;

namespace MotoLog.Business.Interfaces.Respository
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : Base
    {
        Task Insert(TEntity entity);

        Task<TEntity> SelectById(Guid id);

        Task<List<TEntity>> SelectAll();

        Task Update(TEntity entity);

        Task DeleteById(Guid id);

        Task<IEnumerable<TEntity>> SelectAll(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}

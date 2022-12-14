using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression);

        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<bool> Any(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        Task UpdateAsync(T entity);

        Task RemoveAsync(T entity);

        Task RemoveRange(IEnumerable<T> entities);
    }
}

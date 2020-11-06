using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebAPI.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetByIdAsync(Expression<Func<T, bool>> Expression);
        Task<IEnumerable<T>> GetAllAsync();    
        Task<T> AddAsync(T Entity);
        Task<T> UpdateAsync(T Entity);
        Task<bool> DeleteAsync(int Id);
    }
}

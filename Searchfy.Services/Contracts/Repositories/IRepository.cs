using System.Collections.Generic;
using System.Threading.Tasks;

namespace Searchfy.Services.Contracts.Repositories
{
    public interface IRepository<T, S>
        where T : class
        where S : class
    {
        Task<IEnumerable<T>> GetAllAsync(S searchRequest);
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
    }
}

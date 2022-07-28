using System.Linq.Expressions;

namespace Floricultura.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        Task Update(T entity);
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);
    }
}

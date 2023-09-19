using Employees.Common;

namespace Employees.Data.Repository;

public interface IRepository<T> where T: BaseEntity
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Guid id);
    Task<T> AddAsync(T entity);
    Task<bool> DeleteAsync(Guid id);
    Task UpdateAsync(T entity);
    IEnumerable<T> Where(Func<T, bool> func);
    T? Find(Func<T, bool> func);
}

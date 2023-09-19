using Employees.Common;
using Employees.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Employees.Data.Repository;

public class EfRepository<T> : IRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _context;

    public EfRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<T> AddAsync(T entity)
    {
        var result = await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var entity = await _context.Set<T>().FirstOrDefaultAsync(s => s.Id == id);

        if (entity == null) return false;

        entity.IsDeleted = true;
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task UpdateAsync(T entity)
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<T> Where(Func<T, bool> func)
    {
        return _context.Set<T>().Where(func);
    }

    public T? Find(Func<T, bool> func)
    {
        return _context.Set<T>().FirstOrDefault(func);
    }
}

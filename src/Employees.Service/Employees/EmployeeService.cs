using Employees.Common.Models;
using Employees.Data.Repository;

namespace Employees.Service.Employees;

public class EmployeeService : IEmployeeService
{
    private readonly IRepository<Employee> _repository;

    public EmployeeService(IRepository<Employee> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Employee>> GetAll() => await _repository.GetAllAsync();

    public async Task<Employee?> GetById(Guid id) => await _repository.GetByIdAsync(id);

    public async Task<Employee> AddAsync(Employee employee) => await _repository.AddAsync(employee);

    public Task UpdateAsync(Employee employee) => _repository.UpdateAsync(employee);

    public Task<bool> DeleteAsync(Guid id) => _repository.DeleteAsync(id);
}

using Employees.Common.Models;

namespace Employees.Service.Employees;

public interface IEmployeeService
{
    Task<IEnumerable<Employee>> GetAll();
    Task<Employee?> GetById(Guid id);
    Task<Employee> AddAsync(Employee employee);
    Task UpdateAsync(Employee employee);
    Task<bool> DeleteAsync(Guid id);
}

using Employees.Common.Models;
using Employees.Service.Employees;
using MediatR;

namespace Employees.Core.Domain.EmployeeCommand;

public class AddEmployeeCommand : IRequest<Employee>
{
    public AddEmployeeCommand(Employee employee)
    {
        Employee = employee;
    }

    public Employee Employee { get; }
}

public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, Employee>
{
    private readonly IEmployeeService _employeeService;

    public AddEmployeeCommandHandler(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public async Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
    {
        return await _employeeService.AddAsync(request.Employee);
    }
}

using Employees.Common.Models;
using Employees.Service.Employees;
using MediatR;

namespace Employees.Core.Domain.EmployeeCommand;

public class GetAllEmployeesCommand : IRequest<IReadOnlyCollection<Employee>>
{
}

public class GetAllEmployeesCommandHandler : IRequestHandler<GetAllEmployeesCommand, IReadOnlyCollection<Employee>>
{
    private readonly IEmployeeService _employeeService;

    public GetAllEmployeesCommandHandler(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public async Task<IReadOnlyCollection<Employee>> Handle(GetAllEmployeesCommand request, CancellationToken cancellationToken)
    {
        return (await _employeeService.GetAll()).ToArray();
    }
}

using Employees.Service.Employees;
using MediatR;

namespace Employees.Core.Domain.EmployeeCommand;

public class GetByIdEmployeeCommand : IRequest<IReadOnlyCollection<Common.Models.Employee>>, IRequest<Common.Models.Employee>
{
    public GetByIdEmployeeCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}

public class GetByIdEmployeesCommandHandler : IRequestHandler<GetByIdEmployeeCommand, Common.Models.Employee>
{
    private readonly IEmployeeService _employeeService;

    public GetByIdEmployeesCommandHandler(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public async Task<Common.Models.Employee> Handle(GetByIdEmployeeCommand request, CancellationToken cancellationToken)
    {
        return await _employeeService.GetById(request.Id);
    }
}

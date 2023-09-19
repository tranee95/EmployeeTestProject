using Employees.Service.Employees;
using MediatR;

namespace Employees.Core.Domain.EmployeeCommand;

public class DeleteEmployeeCommand : IRequest<bool>
{
    public DeleteEmployeeCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}

public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
{
    private readonly IEmployeeService _employeeService;

    public DeleteEmployeeCommandHandler(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        return await _employeeService.DeleteAsync(request.Id);
    }
}

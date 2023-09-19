using AutoMapper;
using Employees.Common.Models;
using Employees.Common.ViewModel;
using Employees.Core.Domain.EmployeeCommand;
using Microsoft.AspNetCore.Mvc;

namespace Employees.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBaseApi
{
    private readonly ILogger<EmployeesController> _logger;
    private readonly IMapper _mapper;

    public EmployeesController(ILogger<EmployeesController> logger, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<EmployeeViewModel>> GetAllEmployees()
    {
        var result = await Mediator.Send(new GetAllEmployeesCommand());
        return _mapper.Map<IEnumerable<EmployeeViewModel>>(result);
    }

    [HttpGet("{id}")]
    public async Task<EmployeeViewModel> GetByIdEmployee(Guid id)
    {
        var result = await Mediator.Send(new GetByIdEmployeeCommand(id));
        return _mapper.Map<EmployeeViewModel>(result);
    }

    [HttpPost]
    public async Task<EmployeeViewModel> Add([FromBody]AddEmployeeViewModel addEmployeeViewModel)
    {
        var employee = _mapper.Map<Employee>(addEmployeeViewModel);

        var result = await Mediator.Send(new AddEmployeeCommand(employee));
        return _mapper.Map<EmployeeViewModel>(result);
    }

    [HttpDelete]
    public async Task<bool> Delete(Guid id)
    {
        return await Mediator.Send(new DeleteEmployeeCommand(id));
    }
}

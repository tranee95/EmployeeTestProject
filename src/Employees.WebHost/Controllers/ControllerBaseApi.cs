using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Employees.WebHost.Controllers;

public class ControllerBaseApi : ControllerBase
{
    private IMediator? _mediator;
    protected IMediator? Mediator => _mediator ??= _mediator = HttpContext.RequestServices.GetService<IMediator>();
}

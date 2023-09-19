using AutoMapper;
using Employees.Common.Models;
using Employees.Common.ViewModel;

namespace Employees.Service.Mapper;

public class AppMapping : Profile
{
    public AppMapping()
    {
        CreateMap<Employee, EmployeeViewModel>();

        CreateMap<AddEmployeeViewModel, Employee>();
    }
}

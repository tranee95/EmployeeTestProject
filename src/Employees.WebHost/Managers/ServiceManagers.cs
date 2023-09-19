using Employees.Data.Context;
using Employees.Data.Repository;
using Employees.Common.Options;
using Employees.Core.Domain.EmployeeCommand;
using Employees.Service.Employees;
using Employees.Service.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Employees.WebHost.Managers;

public static class ServiceManagers
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllersWithViews();
        services.AddEndpointsApiExplorer();
        services.AddAutoMapper(typeof(AppMapping));
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "Employees API", Version = "v1" });
        });
        services.AddOptions<ConfigurationOptions>().Bind(configuration);
        services.AddMediatR(cfr => cfr.RegisterServicesFromAssemblies(typeof(GetByIdEmployeeCommand).Assembly));
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options
                .UseSnakeCaseNamingConvention()
                .UseSqlite(configuration.GetConnectionString("SqlLite"),
                    s => s.MigrationsAssembly("Employees.Data"));
        });

        services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
        services.AddTransient<IEmployeeService, EmployeeService>();
    }
}

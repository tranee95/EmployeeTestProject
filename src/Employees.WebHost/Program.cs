using Employees.WebHost.Managers;

var builder = WebApplication.CreateBuilder(args);
ServiceManagers.ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();
ConfigureManagers.ConfigureApp(app);

app.Run();

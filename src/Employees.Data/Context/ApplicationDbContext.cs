using Employees.Common.Models;
using Employees.Common.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Employees.Data.Context;

public class ApplicationDbContext : DbContext
{
    private readonly IOptions<ConfigurationOptions> _configuration;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        IOptions<ConfigurationOptions> configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlite(_configuration.Value.ConnectionStrings.SqlLite);

        SQLitePCL.Batteries.Init();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false);

        modelBuilder.Entity<Department>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false);
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
}

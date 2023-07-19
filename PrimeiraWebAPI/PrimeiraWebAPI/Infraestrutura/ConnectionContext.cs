using Microsoft.EntityFrameworkCore;
using PrimeiraWebAPI.Domain.Models.EmployeeAggregate;

// Connection with database
namespace PrimeiraWebAPI.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        // Search in the database this table, making a map
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=employee_sample;" +
            "User id=postgres;" +
            "Password=123;"
            );
    }
}

using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Domain.Model;

namespace PrimeiraAPI.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=DataAPI;" +
                "User Id=postgres;" +
                "Password=123456;");
    }
}

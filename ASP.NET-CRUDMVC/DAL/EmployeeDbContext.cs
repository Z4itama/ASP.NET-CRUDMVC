using ASP.NET_CRUDMVC.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_CRUDMVC.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

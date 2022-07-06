using Microsoft.EntityFrameworkCore;

namespace EmployeesApp.Models
{
    public class HRDatabaseContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-0K11BTV; initial catalog=EmployeeDB; integrated security=SSPI;");
        }
    }
}

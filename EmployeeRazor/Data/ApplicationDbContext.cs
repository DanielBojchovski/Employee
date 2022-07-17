using EmployeeRazor.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}

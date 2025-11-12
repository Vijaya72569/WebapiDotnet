using Microsoft.EntityFrameworkCore;

namespace AzureWebapi.Models
{
    public class EmpDbContext: DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

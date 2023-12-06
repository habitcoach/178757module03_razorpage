using _178757module03_razorpage.Models;
using Microsoft.EntityFrameworkCore;

namespace _178757module03_razorpage.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

    }
}

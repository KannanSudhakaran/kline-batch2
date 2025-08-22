using Lab03JWTAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lab03JWTAPI.Data
{
    public class KlineAppDbContext : DbContext
    {

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public KlineAppDbContext(DbContextOptions<KlineAppDbContext> options) 
            : base(options) { 
        }

    }
}

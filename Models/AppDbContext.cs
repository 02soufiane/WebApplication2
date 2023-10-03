using Microsoft.EntityFrameworkCore;



namespace WebApplication1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employees> Employees { get; set; }

    }
}

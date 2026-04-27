using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using WebApparcial1.Models;

namespace WebApparcial1.Data
{
    public class AppDbContext : DbContext
    {
 
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }

            public DbSet<Productos> Productos { get; set; }

    }
}

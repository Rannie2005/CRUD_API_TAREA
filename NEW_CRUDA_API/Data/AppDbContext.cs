using Microsoft.EntityFrameworkCore;   
using NEW_CRUDA_API.Models;

namespace NEW_CRUDA_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}

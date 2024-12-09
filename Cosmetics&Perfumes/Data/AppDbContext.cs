using Cosmetics_Perfumes.Models;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics_Perfumes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
            
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Purchase.Domain.Entities;

namespace Purchase.Infrastructure.Persistance.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        //{
            
        //}
        public DbSet<Unit>Units { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

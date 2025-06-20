using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Purchase.Infrastructure.Persistance.Context
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionBuilder =new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseSqlServer("server=WINDOWS11;database=Db_POS_Rubayet;User ID=sa;password=Admin123;Encrypt=False;TrustServerCertificate=True");
            return new AppDbContext(optionBuilder.Options);
        }
    }
}

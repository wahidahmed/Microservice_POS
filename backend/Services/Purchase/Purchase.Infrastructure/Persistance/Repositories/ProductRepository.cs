using Purchase.Domain.Entities;
using Purchase.Domain.Interface;
using Purchase.Infrastructure.Persistance.Context;

namespace Purchase.Infrastructure.Persistance.Repositories
{
    /*if we need anyother functions those are not in generic repo then we will create the other function here */
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly AppDbContext dbContext;

        public ProductRepository( AppDbContext dbContext):base(dbContext)// here base is used because the base class GenericRepository has contructor with AppDbContext
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetProductsByUnit(int unitId)
        {
            return dbContext.Products.Where(x=>x.UnitId == unitId);
        }
    }
}

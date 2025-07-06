using Purchase.Domain.Entities;
using Purchase.Domain.Interface;
using Purchase.Infrastructure.Persistance.Context;

namespace Purchase.Infrastructure.Persistance.Repositories
{
    public class UnitRepository:GenericRepository<Unit>,IUnitRepository
    {
        private readonly AppDbContext dbContext;

        public UnitRepository(AppDbContext dbContext) : base(dbContext)// here base is used because the base class GenericRepository has contructor with AppDbContext
        {
            this.dbContext = dbContext;
        }
    }
}

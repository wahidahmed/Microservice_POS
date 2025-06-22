using Microsoft.EntityFrameworkCore;
using Purchase.Domain.Interface;
using Purchase.Infrastructure.Persistance.Context;

namespace Purchase.Infrastructure.Persistance.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal readonly AppDbContext dbContext;
        internal readonly DbSet<TEntity> DbSet;

        public GenericRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.DbSet = dbContext.Set<TEntity>();
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
           var a=await DbSet.AddAsync(entity);
            return a.Entity;
        }

        public void Delete(TEntity entity)
        {
           DbSet.Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
           return await DbSet.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(object id)
        {
           return await DbSet.FindAsync(id);
        }

        public TEntity Update(TEntity entity)
        {
            var a = DbSet.Update(entity);
           return a.Entity;
        }
    }
}
